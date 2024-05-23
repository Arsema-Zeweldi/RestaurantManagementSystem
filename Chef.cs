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
    public partial class Chef : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Chef()
        {
            InitializeComponent();
            GetChefOrders();
            GetMenuItems();
        }

        private void GetChefOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("ChefOrders", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable OrdersTable = new DataTable();
                        adapter.Fill(OrdersTable);

                        // Bind the DataTable to the DataGridView
                        OrdersView.DataSource = OrdersTable;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void GetMenuItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("ViewChefMenuItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable MenuTable = new DataTable();
                        adapter.Fill(MenuTable);

                        // Bind the DataTable to the DataGridView
                        MenuView.DataSource = MenuTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private int GetSelectedMenuItemID()
        {
            int menuItemID = -1;

            if (MenuView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = MenuView.SelectedRows[0]; // Use index 0
                if (selectedRow.Cells["MenuItemID"].Value != null)
                {
                    menuItemID = Convert.ToInt32(selectedRow.Cells["MenuItemID"].Value);
                }
                else
                {
                    MessageBox.Show("Select a Menu Item.");
                }
            }

            return menuItemID;
        }
        private int GetSelectedOrderID()
        {
            int OrderID = -1;

            if (OrdersView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = OrdersView.SelectedRows[0];
                OrderID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);
            }

            return OrderID;
        }

        private void complete_Click(object sender, EventArgs e)
        {
            int OrderID = GetSelectedOrderID();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("MarkOrdersAsComplete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrderID", OrderID);

                        SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(successParam);


                        cmd.ExecuteNonQuery();

                        int success = (int)successParam.Value;

                        if (success == 1)
                        {
                            MessageBox.Show("Order Completed.");
                            GetChefOrders();
                        }
                        else
                        {
                            MessageBox.Show("Failed to complete order.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChefAdd().Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int menuItemID = GetSelectedMenuItemID();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("DeleteMenuItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MenuItemID", menuItemID);

                        SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int);
                        successParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(successParam);

                        cmd.ExecuteNonQuery();

                        int success = (int)successParam.Value;

                        if (success == 1)
                        {
                            MessageBox.Show("Item deleted successfully.");
                            GetMenuItems();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete item.");
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
