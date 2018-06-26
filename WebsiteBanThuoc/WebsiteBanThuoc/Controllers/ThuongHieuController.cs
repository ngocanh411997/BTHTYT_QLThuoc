using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class ThuongHieuController : Controller
    {
        // GET: ThuongHieuPartial
        QLThuocModel db = new QLThuocModel();
        public PartialViewResult ThuongHieuPartial()
        {
            return PartialView(db.ThuongHieux.Take(10).OrderBy(x => x.MaTH).ToList());
        }
        // Hiển thị thuốc theo thương hiệu
        public ViewResult ThuocTheoThuongHieu(int MaTH)
        {
            // Kiểm tra thương hiệu này tồn tại hay ko
            ThuongHieu th = db.ThuongHieux.SingleOrDefault(n => n.MaTH == MaTH);
            if (th == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Thuoc> listthuoc = db.Thuocs.Where(n => n.MaTH == MaTH).OrderBy(n => n.GiaBan).ToList();
            if (listthuoc.Count == 0)
            {
                ViewBag.Thuoc = "Không có thuốc nào thuộc thương hiệu này!";
            }
            return View(listthuoc);
        }
        // Hiển thị danh sách các thương hiệu
        public ViewResult DanhMucThuongHieu()
        {
            return View(db.ThuongHieux.ToList());
        }
    }
}