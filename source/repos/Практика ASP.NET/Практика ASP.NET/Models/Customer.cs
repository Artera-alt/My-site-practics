using static Практика_ASP.NET.Models.Customer;

namespace Практика_ASP.NET.Models
{
    public enum UserRole
    {
        Guest,
        User,
        Admin
    }
    public class Customer
    {
        public Customer(int id, string login, string email,string password, UserRole userrole)
        {
            Id = id;
            Login = login;
            Email = email;
            Password = password;
            UserRole = userrole;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get;set;}
    }
}
