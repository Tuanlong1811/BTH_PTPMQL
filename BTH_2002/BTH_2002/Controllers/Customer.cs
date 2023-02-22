using Microsoft.AspNetCore.Mvc;
using Nguoi.Models;
using System;


namespace Nhansu.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person std)
        {
            string message = std.PersonId + "-";
            message += std.PersonName + "-";
            message += std.Age;
            ViewBag.XX = message;
            return View();
        }
    }
}