using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;
using PagedList;
using PagedList.Mvc;

namespace WebsiteBanThuoc.Controllers
{
    public class ThuocController : Controller
    {
        // GET: /SanPhamMoiPartial
        QLThuocModel db = new QLThuocModel();
        public PartialViewResult SanPhamMoiPartial()
        {
            var listSanPhamMoi = db.Thuocs.Take(3).OrderByDescending(n=>n.MaThuoc).ToList();
            return PartialView(listSanPhamMoi);
        }
        // Xem chi tiết
        public ViewResult XemChiTiet (int MaThuoc=0)
        {
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaThuoc);
            if(thuoc==null)
            {
                // trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            return View(thuoc);
        }
       
        public ViewResult TatCa(int? page)
        {
            // Tạo biến số sản phẩm trên trang
            int pageSize = 12;
            // Tạo biến số trang
            int pageNumber = (page ?? 1);
            var listAll = db.Thuocs.OrderByDescending(n => n.MaThuoc).ToList();
            return View(listAll.ToPagedList(pageNumber,pageSize));
        }
    }
}