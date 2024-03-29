﻿using BTH_2002.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BTH_2002.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       
       [HttpPost]
        public IActionResult Index(string FullName, string Email)
        {
            ViewBag.name = "Hello" + FullName + "-" + Email;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
       
