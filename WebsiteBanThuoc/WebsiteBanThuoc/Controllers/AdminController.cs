using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class AdminController : Controller
    {
        QLThuocModel db = new QLThuocModel();
        // GET: DangNhap
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            string sTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();
            TaiKhoan tk = db.TaiKhoans.SingleOrDefault(n => n.Username == sTaiKhoan && n.Pass == sMatKhau);
            if (tk != null)
            {
                ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
                Session["Admin"] = tk;
                return RedirectToAction("Index", "QuanLySanPham");
            }
            ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
            return View();
        }
    }
}