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
    public partial class Admin : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Admin()
        {
            InitializeComponent();
            reservations();
            orders();
            customers();
            menu();
            staff();
        }
        public void reservations()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllReservations", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable customerReservationsTable = new DataTable();
                        adapter.Fill(customerReservationsTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = customerReservationsTable;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void orders()
        {
           
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllOrders", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable customerOrdersTable = new DataTable();
                        adapter.Fill(customerOrdersTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView2.DataSource = customerOrdersTable;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void customers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllCustomers", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable customerTable = new DataTable();
                        adapter.Fill(customerTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView3.DataSource = customerTable;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void menu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllMenuItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable MenuItemsTable = new DataTable();
                        adapter.Fill(MenuItemsTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView4.DataSource = MenuItemsTable;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private DataTable GetData(string query)
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void LoadDataIntoCharts()
        {
            // Total Reservations
            string reservationsQuery = "SELECT COUNT(*) AS TotalReservations FROM Reservations";
            DataTable reservationsData = GetData(reservationsQuery);
            int totalReservations = Convert.ToInt32(reservationsData.Rows[0]["TotalReservations"]);

            chartReservations.Series.Clear();
            chartReservations.Series.Add("Reservations");
            chartReservations.Series["Reservations"].Points.AddXY("Total Reservations", totalReservations);

            // Total Money Earned
            string moneyEarnedQuery = "SELECT SUM(TotalAmount) AS TotalMoneyEarned FROM Orders";
            DataTable moneyEarnedData = GetData(moneyEarnedQuery);
            decimal totalMoneyEarned = Convert.ToDecimal(moneyEarnedData.Rows[0]["TotalMoneyEarned"]);

            chartMoneyEarned.Series.Clear();
            chartMoneyEarned.Series.Add("Money Earned");
            chartMoneyEarned.Series["Money Earned"].Points.AddXY("Total Money Earned", totalMoneyEarned);

            // Total Customers
            string customersQuery = "SELECT COUNT(DISTINCT CustomerID) AS TotalCustomers FROM Reservations";
            DataTable customersData = GetData(customersQuery);
            int totalCustomers = Convert.ToInt32(customersData.Rows[0]["TotalCustomers"]);

            chartCustomers.Series.Clear();
            chartCustomers.Series.Add("Customers");
            chartCustomers.Series["Customers"].Points.AddXY("Total Customers", totalCustomers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoCharts();
        }


        public void staff()
        {
            string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllStaff", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable StaffTable = new DataTable();
                        adapter.Fill(StaffTable);
                        dataGridView5.DataSource = StaffTable;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("dbo.ResetDailyTransactions", conn))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Log Successfully Saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddStaff().Show();
        }
    }
}
