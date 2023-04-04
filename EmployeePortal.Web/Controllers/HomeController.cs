using System.Diagnostics;
using EmployeePortal.Data.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeePortal.Web.Models;

namespace EmployeePortal.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmployeeData _employeeData;

    public HomeController([FromServices] ILogger<HomeController> logger, [FromServices] IEmployeeData employeeData)
    {
        _employeeData = employeeData;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = _employeeData.GetAll(); 
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}