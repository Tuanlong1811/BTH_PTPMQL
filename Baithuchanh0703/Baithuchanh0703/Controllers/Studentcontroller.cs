using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh0703.Controllers
{
    public class Studentcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Fullname)
        {
            string strReturn="Hello" + Fullname;
            ViewBag.message=strReturn;
            return View();
        }
    }
}
