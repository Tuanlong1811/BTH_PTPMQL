using Microsoft.AspNetCore.Mvc;

namespace BTH_2002.Controllers
{
    public class Helloworldcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

