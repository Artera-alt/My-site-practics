using Microsoft.AspNetCore.Mvc;
using Практика_ASP.NET.Models;

namespace Практика_ASP.NET.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly AuthorizationRepository _repository;

        public AuthorizationController(AuthorizationRepository rep)
        {
            _repository = rep;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _repository.AuthorizationCustomer();
            return View(customers);
        }
    }
}
