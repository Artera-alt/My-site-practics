using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12.DataContext.Models;

namespace WindowsFormsApp12.DataContext
{
    public static class Datacontext
    {
        private static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Малая академия\\source\\repos\\WindowsFormsApp12\\WindowsFormsApp12\\Database1.mdf\";Integrated Security=True";
        public static void AuthorizationUser(string login, string password)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = "select * from [dbo].[User]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {   while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Login = reader.GetString(1);
                            string Password = reader.GetString(2);
                            Role role = (Role)Enum.Parse(typeof(Role), reader.GetString(3));
                            if (Login == reader.GetString(1) && Password == reader.GetString(2))
                            {
                                User Twoform = new User(role);
                                Twoform.Show();
                            }
                        }
                    }
                }
            }
        }
        public static void addGame(string Name)
        {
            MessageBox.Show($"В таблицу было добавлено {Name}");
        }
        public static void DeleteGame(string Name)
        {
            MessageBox.Show($"Из таблицы был убран {Name}");
        }
        public static void EditGame(string Name)
        {
            MessageBox.Show($"Товар {Name} был изменен");
        }
    } 
   
}
