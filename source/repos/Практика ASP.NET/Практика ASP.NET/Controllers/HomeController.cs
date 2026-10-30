using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Практика_ASP.NET.Models;

namespace Практика_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Малая академия\\source\\repos\\Практика ASP.NET\\Практика ASP.NET\\Database1.mdf\";Integrated Security=True";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> product = new List<Product>();
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select * from [dbo].[Product]", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Name = reader.GetString(1);
                            decimal Price = reader.GetDecimal(2);
                            decimal Weight = reader.GetDecimal(3);
                            product.Add(new Product(Id, Name, Price, Weight));
                        }
                    }
                }
            }
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacs()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Workforce()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
