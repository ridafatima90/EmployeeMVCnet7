using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePortal.Data.Models;
using EmployeePortal.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _db;

        public EmployeesController(IEmployeeData db)
        {
            _db = db;
        }
        public IEnumerable<Employee> Get()
        {
            var model = _db.GetAll();
            return model;
        }
    }
}
