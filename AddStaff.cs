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

namespace RestaurantReservationAndOrderingSystem
{
    public partial class AddStaff : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public AddStaff()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("InsertStaffMember", conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                        cmd.Parameters.AddWithValue("@Phone", PhoneBox.Text);
                        if (RoleComboBox.SelectedItem != null)
                        {
                            cmd.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString());

                            SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int);
                            successParam.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(successParam);

                            cmd.ExecuteNonQuery();

                            int success = (int)successParam.Value;
                            if (success == 1)
                            {
                                MessageBox.Show("New Drink Successfully Added.");
                                this.Hide();
                                new Admin().Show();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Drink.");
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
