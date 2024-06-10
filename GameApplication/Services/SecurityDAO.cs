using GameApplication.Models;
using System;
using System.Data.SqlClient;

namespace GameApplication.Services
{
    public class SecurityDAO
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GameAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public bool FindsUserByNamePassword(UserModel user)
        {

            bool success = false;

            string sqlStatement = "SELECT * FROM dbo.Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Log or handle the exception as needed
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return success;
        }
    }
}
