using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservationAndOrderingSystem
{
    public partial class Bar : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";
        public Bar()
        {
            InitializeComponent();
            GetBarMenuItems();
            GetBarOrders();
            BarMenuView.CellEndEdit += dataGridView1_CellEndEdit;
        }
        private void GetBarOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("BarOrders", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable OrdersTable = new DataTable();
                        adapter.Fill(OrdersTable);

                        // Bind the DataTable to the DataGridView
                        BarOrderView.DataSource = OrdersTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void GetBarMenuItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");

                    using (SqlCommand cmd = new SqlCommand("ViewBarMenuItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable MenuTable = new DataTable();
                        adapter.Fill(MenuTable);

                        // Bind the DataTable to the DataGridView
                        BarMenuView.DataSource = MenuTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BarAdd().Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated values from the DataGridView
            DataGridViewRow row = BarMenuView.Rows[e.RowIndex];
            int menuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value);
            string name = row.Cells["Name"].Value.ToString();
            string description = row.Cells["Description"].Value.ToString();
            double price = Convert.ToDouble(row.Cells["Price"].Value);
            string status = row.Cells["AvailabilityStatus"].Value.ToString();

            // Execute the stored procedure to edit the reservation
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("EditDrinks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MenuItemID", menuItemID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@AvailabilityStatus", status);

                    SqlParameter successParam = new SqlParameter("@Success", SqlDbType.Int);
                    successParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(successParam);

                    cmd.ExecuteNonQuery();

                    int success = (int)cmd.Parameters["@Success"].Value;

                    if (success == 1)
                    {
                        MessageBox.Show("Menu updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Menu.");
                    }
                }
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            
        }

        private int GetSelectedMenuItemID()
        {
            int menuItemID = -1;

            if (BarMenuView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BarMenuView.SelectedRows[0]; // Use index 0
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

            if (BarOrderView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = BarOrderView.SelectedRows[0];
                OrderID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);
            }

            return OrderID;
        }
        private void Complete_Click(object sender, EventArgs e)
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
                            GetBarOrders();
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

        private void Add_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new BarAdd().Show();
        }

        private void Delete_Click_1(object sender, EventArgs e)
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
                            GetBarMenuItems();
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

        private void signout2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Signout1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
