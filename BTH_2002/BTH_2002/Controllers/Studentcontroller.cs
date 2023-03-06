using Microsoft.AspNetCore.Mvc;
using Student.Models;


namespace Student.Controllers
{
    public class Studentcontroller : Controller
    {
        public IActionResult Index(string StudentID, string StudentName , string Age)
        {
            ViewBag.ss = "Hello" + StudentID + "-" + StudentName + Age;
            return View();
        }

        public IActionResult Create(Student.Models.Student std)
        {
            string message = std.StudentID + "-";
            message += std.StudentName + "-";
            message += std.Age + "-";
            ViewBag.SS = message;
            return View();
        }

    }
}