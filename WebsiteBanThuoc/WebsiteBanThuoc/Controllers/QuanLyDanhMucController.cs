using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class QuanLyDanhMucController : Controller
    {
        // GET: QuanLyDanhMuc
        QLThuocModel db = new QLThuocModel();
        public ActionResult Index()
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            return View(db.DanhMucs.ToList());
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
        public ActionResult Create(DanhMuc dm)
        {
            if (ModelState.IsValid)
            {
                db.DanhMucs.Add(dm);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int MaDM)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            DanhMuc dm = db.DanhMucs.SingleOrDefault(n => n.MaDM == MaDM);
            if (dm == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(dm);
        }
        [HttpPost]
        public ActionResult Edit(DanhMuc dm)
        {
            if (ModelState.IsValid)
            {
                //Thực hiện cập nhận trong model
                db.Entry(dm).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int MaDM)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            //Lấy ra đối tượng sách theo mã 
            DanhMuc dm = db.DanhMucs.SingleOrDefault(n => n.MaDM == MaDM);
            if (dm == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(dm);
        }
        [HttpPost, ActionName("Delete")]

        public ActionResult XacNhanXoa(int MaDM)
        {
            DanhMuc dm = db.DanhMucs.SingleOrDefault(n => n.MaDM == MaDM);
            if (dm == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.DanhMucs.Remove(dm);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}