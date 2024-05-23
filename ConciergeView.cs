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
    public partial class ConciergeView : Form
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";

        public ConciergeView()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            view();
        }
        public void view()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlCommand cmd = new SqlCommand("dbo.ViewAllReservations", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable customerReservationsTable = new DataTable();
                        adapter.Fill(customerReservationsTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = customerReservationsTable;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated values from the DataGridView
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int reservationID = Convert.ToInt32(row.Cells["ReservationID"].Value);
            int tableID = Convert.ToInt32(row.Cells["TableID"].Value);
            string name = row.Cells["Name"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            DateTime reservationDate = Convert.ToDateTime(row.Cells["ReservationDate"].Value);
            TimeSpan reservationTime = TimeSpan.Parse(row.Cells["ReservationTime"].Value.ToString());
            string status = row.Cells["Status"].Value.ToString();
            int guests = Convert.ToInt32(row.Cells["Guests"].Value);
            string specialRequests = row.Cells["SpecialRequests"].Value.ToString();

            // Execute the stored procedure to edit the reservation
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.EditReservation", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@TableID", tableID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    cmd.Parameters.AddWithValue("@ReservationTime", reservationTime);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Guests", guests);
                    cmd.Parameters.AddWithValue("@SpecialRequests", specialRequests);

                    // Execute the command
                    int editSuccess = (int)cmd.ExecuteScalar();
                    if (editSuccess == 1)
                    {
                        MessageBox.Show("Reservation updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update reservation.");
                    }
                }
            }
        }

        private void DeleteReservation(int reservationID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteReservation", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    // Execute the command
                    int deleteSuccess = (int)cmd.ExecuteScalar();
                    if (deleteSuccess == 1)
                    {
                        MessageBox.Show("Reservation deleted successfully.");
                        // Optionally, update the DataGridView to reflect the changes
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete reservation.");
                    }
                }
            }
        }
        private int GetSelectedReservationID()
        {
            int reservationID = -1;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                reservationID = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);
            }

            return reservationID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reservationID = GetSelectedReservationID();
            DeleteReservation(reservationID);
            view();
        }
    }
}
