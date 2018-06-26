using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class DangNhapController : Controller
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
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
            if (kh != null)
            {
                ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
                Session["TaiKhoan"] = kh;
                //ViewBag.TenTK = kh.HoTen;
                return RedirectToAction("Index", "Home");

            }
            ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
            return View();
        }

        public ActionResult Logout()
        {
            Session["TaiKhoan"] = "";
            Session["GioHang"] = null;
            return RedirectToAction("Index", "Home");

        }

        public string TaiKhoan()
        {
            string Name = "";
            KhachHang kh = Session["TaiKhoan"] as KhachHang;
            if (kh != null)
            {
                Name = kh.HoTen;
            }
            return Name;
        }
        public ActionResult TKPartial()
        {
            if (TaiKhoan() == "")
            {
                ViewBag.DN = "Đăng nhập";
                ViewBag.DK = "Đăng ký";

                return PartialView();
            }
            ViewBag.Name = "Xin chào, " + TaiKhoan();
            ViewBag.DX = "Đăng xuất";

            return PartialView();
        }
        /// <summary>
        /// Thông tin khách hàng
        /// </summary>
        /// <param name="MaKH"></param>
        /// <returns></returns>
        public ActionResult ThongTinKH(int MaKH = 0)
        {
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.MaKH == MaKH);
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(kh);
        }
    }
}