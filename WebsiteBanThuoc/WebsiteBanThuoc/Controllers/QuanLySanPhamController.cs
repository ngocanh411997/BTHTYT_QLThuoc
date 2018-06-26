using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;


namespace WebsiteBanThuoc.Controllers
{
    public class QuanLySanPhamController : Controller
    {

        // GET: QuanLySanPham
        QLThuocModel db = new QLThuocModel();
        public ActionResult Index(int? page)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            //Kiểm tra đăng đăng nhập

            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(db.Thuocs.ToList().OrderBy(n=>n.MaThuoc).ToPagedList(pageNumber,pageSize));
        }
        //Thêm mới
        [HttpGet]
        public ActionResult ThemMoi()
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            ViewBag.MaDM = new SelectList(db.DanhMucs.ToList().OrderBy(n => n.TenDM), "MaDM", "TenDM");
            ViewBag.MaTH = new SelectList(db.ThuongHieux.ToList().OrderBy(n => n.TenTH), "MaTH", "TenTH");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(Thuoc thuoc, HttpPostedFileBase fileupload)
        {
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaDM = new SelectList(db.DanhMucs.ToList().OrderBy(n => n.TenDM), "MaDM", "TenDM");
            ViewBag.MaTH = new SelectList(db.ThuongHieux.ToList().OrderBy(n => n.TenTH), "MaTH", "TenTH");
            //kiểm tra đường dẫn ảnh bìa
            if (fileupload == null)
            {
                ViewBag.ThongBao = "Chọn hình ảnh";
                return View();
            }
            //Thêm vào cơ sở dữ liệu
            if (ModelState.IsValid)
            {
                //Lưu tên file
                var fileName = Path.GetFileName(fileupload.FileName);
                //Lưu đường dẫn của file
                var path = Path.Combine(Server.MapPath("~/HinhAnhSP"), fileName);
                //Kiểm tra hình ảnh đã tồn tại chưa
                if (System.IO.File.Exists(path))
                {
                    ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    return View();
                }
                else
                {
                    fileupload.SaveAs(path);
                }
                thuoc.AnhBia = fileupload.FileName;
                db.Thuocs.Add(thuoc);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ChinhSua(int MaThuoc)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaThuoc);
            if(thuoc==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaDM = new SelectList(db.DanhMucs.ToList().OrderBy(n => n.TenDM), "MaDM", "TenDM");
            ViewBag.MaTH = new SelectList(db.ThuongHieux.ToList().OrderBy(n => n.TenTH), "MaTH", "TenTH");
            return View(thuoc);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(Thuoc thuoc)
        {
            if (ModelState.IsValid)
            {
                //Thực hiện cập nhận trong model
                db.Entry(thuoc).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //Đưa dữ liệu vào dropdownlist
            ViewBag.MaDM = new SelectList(db.DanhMucs.ToList().OrderBy(n => n.TenDM), "MaDM", "TenDM", thuoc.MaDM);
            ViewBag.MaTH = new SelectList(db.ThuongHieux.ToList().OrderBy(n => n.TenTH), "MaTH", "TenTH", thuoc.MaTH);

            return RedirectToAction("Index");
        }

        //Hiển thị sản phẩm
        public ActionResult ChiTiet(int MaThuoc)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }

            //Lấy ra đối tượng sách theo mã 
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaThuoc);
            if (thuoc == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(thuoc);

        }
        //Xóa sản phẩm
        [HttpGet]
        public ActionResult Xoa(int MaThuoc)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            //Lấy ra đối tượng sách theo mã 
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaThuoc);
            if (thuoc == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(thuoc);
        }
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(int MaThuoc)
        {
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaThuoc);
            if (thuoc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.Thuocs.Remove(thuoc);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}