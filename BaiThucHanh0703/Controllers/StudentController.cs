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
        public IActionResult GiaiPhuongTrinhBac1()
       {
        return View();
       }
      


       public IActionResult GiaiPhuongTrinhBac2()
       {
        return View();
       }
       [HttpPost]
        public IActionResult GiaiPhuongTrinhBac2(string hesoA, string hesoB, string hesoC)
       {
        //khai bao bien
        double delta , x1, x2, a=0, b=0, c=0;
        string ketqua;
        //giai phuong trinh bac 2.có dự liệu của hệ số A từ view gửi lên, chuyển đổi kiểu dữ liệu từ string sang double và gán vào a
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
         if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
          if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a == 0) ketqua = "Khong phai phuong trinh bac 2";
        else
        {
          //tinh delta
          delta = Math.Pow(b,2) - 4*a*c;
          //giai phuong trinh
          if(delta < 0) ketqua = "Phuong trinh vo nghiem";
          else if(delta == 0)
          {
            x1 = -b/(2*a);
            ketqua = "Phuong trinh co nghiem kep = " + x1;
          }
          else
          {
            x1 = (-b + Math.Sqrt(delta))/(2*a);
            x2 = (-b - Math.Sqrt(delta))/(2*a);
            ketqua = "Phuong trinh co 2 nghiem phan biet: x1 =" + x1 + ", x2 = " + x2;
          }
        }
        @ViewBag.message = ketqua ;
        return View();
       }




    }
   
}