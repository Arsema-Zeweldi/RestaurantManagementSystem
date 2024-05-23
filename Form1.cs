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
    public partial class Form1 : Form
    {
        User newUser;
        public Form1()
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            newUser = new User();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            
            string password = textBox2.Text;
            string role = newUser.signin(username, password);
            if (String.Compare(role, "Admin") == 0)
            {
                this.Hide();
                new Admin().Show();
                
            } else if (String.Compare(role, "Concierge") == 0)
            {
                this.Hide();
                new ConciergeMain().Show();
            } else if (String.Compare(role, "Cashier") == 0)
            {
                this.Hide();
                new Cashier().Show();
            } else if (String.Compare(role, "Waiter") == 0 || String.Compare(role, "Waitress") == 0)
            {
                this.Hide();
                new Waiter().Show();
            } else if (String.Compare(role, "Chef") == 0)
            {
                this.Hide();
                new Chef().Show();
            } else if (String.Compare(role, "Bartender") == 0)
            {
                this.Hide();
                new Bar().Show();
            } else
            {
                MessageBox.Show("User Not Found.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();
                        Console.WriteLine("Connection opened successfully.");

                        // Create a command object
                        using (SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", connection))
                        {
                            // Execute the command and retrieve the data
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Check if the reader has any rows
                                if (reader.HasRows)
                                {
                                    Console.WriteLine("Categories:");
                                    while (reader.Read())
                                    {
                                        // Read and display each category
                                        int categoryID = reader.GetInt32(0);
                                        string categoryName = reader.GetString(1);
                                        //richTextBox1.Text += "ID: " + categoryID + ", Name: " + categoryName + "\n";
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No categories found.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        // Close the connection
                        connection.Close();
                        Console.WriteLine("Connection closed.");
                    }
                }
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
