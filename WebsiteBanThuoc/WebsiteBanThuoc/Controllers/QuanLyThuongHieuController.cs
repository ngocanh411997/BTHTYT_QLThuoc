using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class QuanLyThuongHieuController : Controller
    {
        // GET: QuanLyThuongHieu
        QLThuocModel db = new QLThuocModel();
        public ActionResult Index()
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            return View(db.ThuongHieux.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(ThuongHieu th)
        {
            if (ModelState.IsValid)
            {
                db.ThuongHieux.Add(th);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int MaTH)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            ThuongHieu th = db.ThuongHieux.SingleOrDefault(n => n.MaTH == MaTH);
            if (th == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(th);
        }
        [HttpPost]
        public ActionResult Edit(ThuongHieu th)
        {
            if (ModelState.IsValid)
            {
                //Thực hiện cập nhận trong model
                db.Entry(th).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int MaTH)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            //Lấy ra đối tượng sách theo mã 
            ThuongHieu th = db.ThuongHieux.SingleOrDefault(n => n.MaTH == MaTH);
            if (th == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(th);
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult XacNhanXoa(int MaTH)
        {
            ThuongHieu th = db.ThuongHieux.SingleOrDefault(n => n.MaTH == MaTH);
            if (th == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.ThuongHieux.Remove(th);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}