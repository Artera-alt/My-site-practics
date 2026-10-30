using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using Практика_ASP.NET.Models;

namespace Практика_ASP.NET.Controllers
{
    public class LoginRepository
    {
        private static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Малая академия\\source\\repos\\Практика ASP.NET\\Практика ASP.NET\\Database1.mdf\";Integrated Security=True";
        
        public static string LoginCustomer(string login,string email,string password)
        { 
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
               
                return "Заполните все поля!"; 
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                return "Некорректный формат email!";
            }

            string query = $"INSERT INTO [dbo].[Customer] (Login, Email, Password) VALUES ({login}, {email}, {password})";

            using (var connection = new SqlConnection(connect))
            {
                connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    return "Регистрация прошла успешно.";
                }
            }
        }
        
    }
}
