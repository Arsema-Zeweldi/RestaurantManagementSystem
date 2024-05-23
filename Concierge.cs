using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantReservationAndOrderingSystem
{
    public partial class Concierge : Form
    {
        string selectedTime;
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Concierge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("usp_AddCustomerIfNotExists", conn))
                    {
                        string email = EmailBox.Text;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", NumberBox.Text);

                        int customerID = (int)cmd.ExecuteScalar();
                        Console.WriteLine(customerID);


                        using (SqlCommand cmd2 = new SqlCommand("usp_Addreservation", conn))
                        {

                            int selectedTableID = ((ComboBoxItem)TableComboBox.SelectedItem).Value;
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd2.Parameters.AddWithValue("@TableID", selectedTableID);
                           
                            cmd2.Parameters.AddWithValue("@ReservationTime", selectedTime);
                            cmd2.Parameters.AddWithValue("@Guests", Convert.ToInt32(GuestsBox.Text));
                            cmd2.Parameters.AddWithValue("@SpecialRequests", SpecialBox.Text);

                            SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int);
                            successParam.Direction = ParameterDirection.Output;
                            cmd2.Parameters.Add(successParam);

                            // Execute the command
                            cmd2.ExecuteNonQuery();

                            // Get the output parameter value
                            int success = (int)successParam.Value;

                            if (success == 1)
                            {
                                MessageBox.Show("Reservation Added");
                            }
                            else
                            {
                                MessageBox.Show("Error. Reservation not added.");
                            }


                        }

                    }
                }
                
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadAvailableTables()
        {
            
            try {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("usp_GetAvailableTables", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MinSeatingCapacity", Convert.ToInt32(GuestsBox.Text));
           
                        command.Parameters.AddWithValue("@ReservationTime", selectedTime);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            TableComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                int tableID = reader.GetInt32(0);
                                int tableNumber = reader.GetInt32(1);
                                TableComboBox.Items.Add(new ComboBoxItem("Table " + tableNumber, tableID));
                            }
                        }
                        
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void GuestsBox_TextChanged(object sender, EventArgs e)
        {
            //LoadAvailableTables();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConciergeMain cm = new ConciergeMain();
            cm.Show();
        }

        private void ReservationTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTime = ReservationTimeComboBox.SelectedItem.ToString();
            LoadAvailableTables();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
