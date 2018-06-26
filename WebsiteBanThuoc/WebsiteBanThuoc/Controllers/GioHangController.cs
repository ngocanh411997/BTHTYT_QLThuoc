using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanThuoc.Models;

namespace WebsiteBanThuoc.Controllers
{
    public class GioHangController : Controller
    {
        QLThuocModel db = new QLThuocModel();
       // Lấy giỏ hàng
       public List<GioHang> LayGioHang()
        {
            List<GioHang> listGioHang = Session["GioHang"] as List<GioHang>;
            if(listGioHang==null)
            {
                // Nếu giỏ hàng chưa tồn tại thì tiến hành khởi tạo list giỏ hàng ( session GioHang)
                listGioHang = new List<GioHang>();
                Session["GioHang"] = listGioHang;
            }
            return listGioHang;
        }
        // Thêm giỏ hàng
        public ActionResult ThemGioHang(int MaSP, string strURL)
        {
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaSP);
            if(thuoc==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            // Lấy ra session giỏ hàng
            List<GioHang> listGioHang = LayGioHang();
            // Kiểm tra thuốc đã tồn tại trong session[GioHang] chưa
            GioHang sanpham = listGioHang.Find(n => n.MaSP == MaSP);
            if(sanpham==null)
            {
                sanpham = new GioHang(MaSP);
                // Add sp mới thêm vào list
                listGioHang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.SoLuong++;
                return Redirect(strURL);
            }
        }
        // cập nhật giỏ hàng
        public ActionResult CapNhatGioHang(int  MaSP, FormCollection f)
        {
            // Kiểm tra mã sp
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaSP);
           
            if(thuoc==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> listGioHang = LayGioHang();
            GioHang sanpham = listGioHang.SingleOrDefault(n => n.MaSP == MaSP);
            if(sanpham != null)
            {
                sanpham.SoLuong = int.Parse(f["txtSoLuong"].ToString());
              
            }
            return RedirectToAction("GioHang");
        }
        // Xóa giỏ hàng
        public ActionResult XoaGioHang(int MaSP)
        {
            // Kiểm tra mã sp
            Thuoc thuoc = db.Thuocs.SingleOrDefault(n => n.MaThuoc == MaSP);

            if (thuoc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> listGioHang = LayGioHang();
            GioHang sanpham = listGioHang.SingleOrDefault(n => n.MaSP == MaSP);
            if (sanpham != null)
            {
                listGioHang.RemoveAll(n => n.MaSP == MaSP);

            }
            if(listGioHang.Count==0)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("GioHang");
        }
        // Xây dựng trang giỏ hàng
        public ActionResult GioHang()
        {
            if(Session["GioHang"]== null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<GioHang> listGioHang = LayGioHang();
 
            return View(listGioHang);
        }
       // Tính tổng số lượng và tổng tiền

        // Tính tổng số lượng
        public int TongSoLuong()
        {
            int TongSoLuong = 0;
            List<GioHang> listGioHang = Session["GioHang"] as List<GioHang>;
            if(listGioHang !=null)
            {
                TongSoLuong = listGioHang.Count();
            }
            return TongSoLuong;
        }
        // Tính tổng thành tiền
        private double TongTien()
        {
            double TongTien = 0;
            List<GioHang> listGioHang = Session["GioHang"] as List<GioHang>;
            if (listGioHang !=null)
            {
                TongTien = listGioHang.Sum(n => n.ThanhTien);
            }
            return TongTien;
        }
        // Tạo partial giỏ hàng
        public ActionResult GioHangPartial()
        {
            if(TongSoLuong()==0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }

        public ActionResult TongTienPartial()
        {
            if (TongSoLuong() == 0)
            {
                return PartialView();
            }
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
        // Xây dựng 1 view cho người dùng chỉnh sửa giỏ hàng
        public ActionResult SuaGioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<GioHang> listGioHang = LayGioHang();

            return View(listGioHang);
        }
        // Đặt hàng
        // Xây dựng chức năng đặt hàng
        [HttpPost]
        public ActionResult DatHang()
        {
            // Kiểm tra đăng nhập
            if(Session["TaiKhoan"]==null|| Session["TaiKhoan"].ToString()=="")
            {
                // Đăng nhập
                return RedirectToAction("Login", "DangNhap");
            }
            // Kiểm tra giỏ hàng
            if(Session["GioHang"]==null)
            {
                RedirectToAction("Index", "Home");
            }
            // Thêm đơn đặt hàng
            DonHang dh = new DonHang();
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            List<GioHang> gh = LayGioHang();
            dh.MaKH = kh.MaKH;
            dh.NgayDat = DateTime.Now;

            db.DonHangs.Add(dh);
            db.SaveChanges();
            // Thêm chi tiết đơn hàng
            foreach(var item in gh)
            {
                ChiTietDonHang CTDH = new ChiTietDonHang();
                CTDH.MaDonHang = dh.MaDonHang;
                CTDH.MaThuoc = item.MaSP;
                CTDH.SoLuong = item.SoLuong;
                CTDH.DonGia = (decimal)item.GiaBan;
                db.ChiTietDonHangs.Add(CTDH);
            }
           
            db.SaveChanges();
            Session["GioHang"] = null;   
            return RedirectToAction("Index","Home");
        }

    }
}