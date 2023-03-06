using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh_0703.Controllers
{
    public class Studentcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            ViewBag.message = strReturn;
            return View();
        }
        [HttpPost]
        public IActionResult Giaiptbac2(string hesoA, string hesoB, string hesoC)
        {
            double delta, x1, x2, a = 0, b = 0, c = 0;
            string ketqua;
            if(!string.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
            if (!string.IsNullOrEmpty(hesoB)) a = Convert.ToDouble(hesoB);
            if (!string.IsNullOrEmpty(hesoC)) a = Convert.ToDouble(hesoC);
            if (a == 0) ketqua = "khong phai pt bac 2";
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0) ketqua = "Phuong trinh vo nghiem";
                else if(delta == 0)
                {
                    x1 = -b / (2 * a);
                    ketqua = "phuong trinh co nghiem kep =" + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketqua="phuong trinh co 2 nghiem phan biet: X1 =" + x1+ "X2=" + x2;
                }
            }
            return View(ketqua);
        }
    }
}
