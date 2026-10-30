using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using System;
using Практика_ASP.NET.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using AspNetCore;
using System.Security.Cryptography.X509Certificates;

namespace Практика_ASP.NET.Controllers
{
    public class AuthorizationRepository
    {
        private static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Малая академия\\source\\repos\\Практика ASP.NET\\Практика ASP.NET\\Database1.mdf\";Integrated Security=True";

        public async  Task<List<Customer>> AuthorizationCustomer()
        {
            var customer = new List<Customer>();

            using (var connection = new SqlConnection(connect))
            {
                await connection.OpenAsync();

                var command = new SqlCommand("SELECT * FROM [dbo].[Customer]", connection);

                using (var reader = await command.ExecuteReaderAsync())
                {
     
                    while (await reader.ReadAsync())
                    {
                        int Id = reader.GetInt32(0);
                        string Login = reader.GetString(1);
                        string Email = reader.GetString(2);
                        string Password = reader.GetString(3);
                        UserRole UserRole =(UserRole)Enum.Parse(typeof(UserRole),reader.GetString(4));
                        customer.Add(new Customer(Id, Login,Email, Password, UserRole ));
                        if (Login == reader.GetString(1) && Password == reader.GetString(3))
                        {
                            return customer;
                        }
                    }
                }
                return null;
            }
        }
    }
}
