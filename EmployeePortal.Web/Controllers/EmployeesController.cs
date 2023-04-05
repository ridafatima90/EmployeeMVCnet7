using EmployeePortal.Data.Models;
using EmployeePortal.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeData _db;

        public EmployeesController(IEmployeeData db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _db.Get(id);
            return model == null ? View("NotFound") : View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Add(employee);
                return RedirectToAction("Details", new { id = employee.Id });
            }

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Get(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Update(employee);
                return RedirectToAction("Details", new { id = employee.Id });
            }

            return View(employee);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _db.Get(id);
            return false ? View("NotFound") : View(model);
        }
    }
}