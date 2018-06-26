using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteBanThuoc.Models
{
    public class GioHang
    {
        QLThuocModel db = new QLThuocModel();
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * GiaBan; }
        }
       
        //Hàm tạo cho giỏ hàng
        public GioHang(int _MaSP)
        {
            MaSP = _MaSP;
            Thuoc thuoc = db.Thuocs.Single(n => n.MaThuoc == MaSP);
            TenSP = thuoc.TenThuoc;
            HinhAnh = thuoc.AnhBia;
            GiaBan = double.Parse(thuoc.GiaBan.ToString());
            SoLuong = 1;
        }
    }
}