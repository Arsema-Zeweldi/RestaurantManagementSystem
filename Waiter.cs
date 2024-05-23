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
    public partial class Waiter : Form
    {
        string selectedMenuItem;
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Waiter()
        {
            InitializeComponent();
            GetCategories();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            //ViewMenuItem();
        }

        private void addMenuItem()
        {

        }

        private void GetCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewCategories", conn))
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
                
                
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }



        }

        private void ViewMenuItem(string selectedCategory)
        { 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewCategoryMenuItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CategoryName", selectedCategory);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listBox1.Items.Clear();
                            while (reader.Read())
                            {
                                listBox1.Items.Add(reader.GetString(0));
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
        public class ComboBoxItem
        {
            public string Text { get; set; }

            public ComboBoxItem(string text)
            {
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedCategory = comboBox1.SelectedItem.ToString();
                ViewMenuItem(selectedCategory);
            } else
            {
                MessageBox.Show("Please select a category.");
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedMenuItem = listBox1.SelectedItem.ToString();
               
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox2.Text, out int quantity))
            {
                // Add item to the list box
                listBox2.Items.Add($"{selectedMenuItem} - {quantity}");

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        Console.WriteLine("Connection opened successfully");

                        using (SqlCommand cmd = new SqlCommand("CreateOrders", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@TableID", Convert.ToInt32(textBox1.Text));
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@MenuItemName", selectedMenuItem);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }   
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Complete");
            this.Hide();
            new Waiter().Show();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
