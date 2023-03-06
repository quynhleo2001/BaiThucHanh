using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
       {
         return View();
       }
        [HttpPost]
        public  IActionResult Index(string FullName)
        {
        string strReturn = "Hello" + FullName;
        @ViewBag.message = strReturn;
        return View();
        }
        public IActionResult TinhTong()
       {
         return View();
       }
       [HttpPost]
        public  IActionResult TinhTong(string Number)
       {
        //chuyen doi kieu du lieu tu string sang int
        int so = Convert.ToInt32(Number);
        int tong = 0;
        while(so > 0)
        {
            tong = tong + so%10;
            so = so/10;
        }
        @ViewBag.Sum = "Tong cua cac so" + Number + "=" + tong;

         return View();
       }



    }
   
}