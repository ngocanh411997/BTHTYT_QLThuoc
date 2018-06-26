using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class DanhMucController : Controller
    {
        // GET: DanhMuc
        QLThuocModel db = new QLThuocModel();
        public ActionResult DanhMucPartial()
        {
            return PartialView(db.DanhMucs.ToList());
        }
        // Thuốc theo danh mục
        public ViewResult ThuocTheoDanhMuc(int MaDM=0)
        {
            // Kiểm tra danh mục này tồn tại hay ko
            DanhMuc dm = db.DanhMucs.SingleOrDefault(n => n.MaDM == MaDM);
            if(dm==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Thuoc> listthuoc = db.Thuocs.Where(n => n.MaDM == MaDM).OrderBy(n => n.GiaBan).ToList();
            if(listthuoc.Count==0)
            {
                ViewBag.Thuoc = "Không có thuốc nào thuộc danh mục này!";
            }
            return View(listthuoc);
        }
    }
}