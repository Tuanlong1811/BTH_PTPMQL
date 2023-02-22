using Microsoft.AspNetCore.Mvc;
using Congnhan.Models;


namespace Congnhan.Controllers
{
    public class Employeecontroller : Controller
    {
        public IActionResult Index(string EmployeeID, string EmployeeName , string Age)
        {
            ViewBag.ss = EmployeeID + "-" + EmployeeName + "-" Age  ;
            return View();
        }

        public IActionResult Create(Employee std)
        {
            string message = std.EmployeeID + "-";
            message += std.EmployeeName + "-";
            message += std.Age + "-";
            ViewBag.SS = message;
            return View();
        }

    }
}