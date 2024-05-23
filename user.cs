using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RestaurantReservationAndOrderingSystem
{
    public class User
    {
        string connectionString = "Server=LAPTOP-FH6MBUML\\MSSQLSERVER01;Database=Restaurant;Integrated Security=true";

        
        public string signin(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Connection opened successfully");
                    using (SqlCommand cmd = new SqlCommand("dbo.CheckStaffLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlParameter roleParam = new SqlParameter("@Role", SqlDbType.NVarChar, 50);
                        roleParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(roleParam);



                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Check login success status
                        string role = roleParam.Value.ToString();

                        // Check if the role is empty to determine login success
                        if (!string.IsNullOrEmpty(role))
                        {
                            Console.WriteLine("Login successful. User exists in the database.");
                            return role;
                        }
                        else
                        {
                            Console.WriteLine("Login failed. Username or password is incorrect.");
                            return "";
                        }
                    }
                }
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
}
