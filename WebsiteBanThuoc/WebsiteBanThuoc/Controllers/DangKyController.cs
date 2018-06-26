using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;


namespace WebsiteBanThuoc.Controllers
{
    public class DangKyController : Controller
    {
        // GET: DangKy
        QLThuocModel db = new QLThuocModel();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ThongBao = "Đăng ký không hợp lệ";
                return View();
            }

        }
    }
}