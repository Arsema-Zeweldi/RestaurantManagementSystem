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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantReservationAndOrderingSystem
{
    public partial class ChefAdd : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public ChefAdd()
        {
            InitializeComponent();
            GetCategories();
        }

        private void GetCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewChefCategories", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            comboBox1.Items.Clear();
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("AddNewItem", conn))
                    {
                        string name = NameBox.Text;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);
                        cmd.Parameters.AddWithValue("@Price", PriceBox.Text);
                        if (StatusComboBox.SelectedItem != null && comboBox1.SelectedItem != null)
                        {
                            cmd.Parameters.AddWithValue("@CategoryName", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@AvailabilityStatus", StatusComboBox.SelectedItem.ToString());
                            
                            SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int);
                            successParam.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(successParam);

                            cmd.ExecuteNonQuery();

                            int success = (int)successParam.Value;
                            if (success == 1)
                            {
                                MessageBox.Show("New Item Successfully Added.");
                                this.Hide();
                                new Chef().Show();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Item.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please choose availability status.");
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    

}
