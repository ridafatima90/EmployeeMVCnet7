using EmployeePortal.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Web.Controllers
{
    public class GreetingController : Controller
    {
        private readonly IConfiguration _config;

        public GreetingController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index(string name)
        {
            var model = new GreetingViewModel
            {
                Message = _config["Message"],
                Name = name ?? "Anyone"
            };
            return View(model);
        }
    }
}