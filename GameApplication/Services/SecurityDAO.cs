using GameApplication.Models;
using System.Data.SqlClient;

namespace GameApplication.Services
{
    public class SecurityDAO
    {
        string connectionString;

        public bool FindUserByUsernameAndEmail(UserModel user)
        {
            //assuming nothing is found
            bool success = false;

            //using prepared statements for security. 
            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username and email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                //values defined of the placeholders in the sqlStatement string
                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 40).Value = user.Username;
                command.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar, 99).Value = user.Email;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };
            }
            return success;
        }

    }
}
