using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class HomeController : Controller
    {
        QLThuocModel db = new QLThuocModel();
        public ActionResult Index()
        {
            return View(db.Thuocs.Take(12).OrderByDescending(n=>n.MaThuoc).ToList());
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