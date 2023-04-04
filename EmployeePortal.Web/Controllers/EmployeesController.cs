using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}