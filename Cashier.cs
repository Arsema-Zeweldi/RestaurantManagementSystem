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
    public partial class Cashier : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Cashier()
        {
            InitializeComponent();
        }
        public void GetOrders(int TableID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");
                    double price = 0;
                    
                    using (SqlCommand cmd = new SqlCommand("RetrieveOrders", conn)) 
                    {
                        Console.WriteLine("in");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TableNumber", TableID);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable customerReservationsTable = new DataTable();
                        adapter.Fill(customerReservationsTable);

                        dataGridView1.DataSource = customerReservationsTable;
                    }
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Access the value of the desired column by column name
                            var cellValue = row.Cells["Price"].Value;
                            price += Convert.ToDouble(cellValue);
                            //Console.WriteLine(cellValue);
                        }
                    }

                    textBox2.Text = price.ToString();
                    
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TableID = Convert.ToInt32(TableNumberBox.Text);
            GetOrders(TableID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recipt Printed.");
            this.Hide();
            new Cashier().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
