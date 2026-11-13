using Microsoft.AspNetCore.Mvc;

namespace Практика_ASP.NET.Controllers
{
    public class WorkforceController : Controller
    {
        private readonly WorkforceRepository _repository;

        public WorkforceRepository(WorkforceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var Workforce = await _repository.GetWorkforceAsync();
            return View(Workforce);
        }
    }
}
