using Microsoft.AspNetCore.Mvc;

namespace Практика_ASP.NET.Controllers
{
    public class WorkforceController : Controller
    {
        private readonly WorkforceRepository _repository;

        public WorkforceController(WorkforceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Workforce()
        {
            var Workforce = await _repository.GetWorkforceAsync();
            return View(Workforce);
        }
    }
}
