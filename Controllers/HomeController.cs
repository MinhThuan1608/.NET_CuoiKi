using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesProject.Models;
using System.Collections;
using System.Threading;
namespace ShoesProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
        public ActionResult Index()
        {
            // Lay ra 1 tai khoan trong db dua tren username
            /*ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            account acc = db.accounts.SingleOrDefault(x => x.username == "bedang");
            return View(acc);*/


            // Lay ra danh sach san pham tu db
            var lstSP = db.shoes.ToList();
            Console.Write(lstSP);
            //gán vao ViewBag
            ViewBag.ListSP = lstSP;

            return View();
        }

        public ActionResult MenuPartial()
        {
            var lstSanPham = db.shoes;

            return PartialView(lstSanPham);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}