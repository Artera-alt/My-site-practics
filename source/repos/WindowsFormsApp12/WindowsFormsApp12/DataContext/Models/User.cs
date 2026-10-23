using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12.DataContext.Models
{
    public enum Role 
    {
        Admin,
        Manager,
        User
    }
    public class User
    {
        public User(int id, string login, string password, Role role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = role;
        }

        private int Id { get; set; }
        public string Login { get; set; }
        public string Password{ get; set; }
        public Role Role { get; set; }
    }
}
