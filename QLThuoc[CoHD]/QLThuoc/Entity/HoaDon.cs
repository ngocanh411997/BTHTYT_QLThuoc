using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLThuoc.Entity
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public int Gia { get; set; }
        public int ThanhTien { get; set; }
        public int TongTien { get; set; }

        public HoaDon()
        {
            MaHD = "";
            MaNV = "";
            NgayXuat = DateTime.Parse("01/01/2017");
            MaKH = "";
            TenKH = "";
            TenThuoc = "";
            SoLuong = 0;
            DonViTinh = "";
            Gia = 0;
            ThanhTien = 0;
            TongTien = 0;
        }
        public HoaDon(string _MaHD, string _MaNV, DateTime _NgayXuat, string _MaKH, string _TenKH, string _TenThuoc, int _SL, string _DVT, int _Gia, int _ThanhTien, int _TongTien)
        {
            MaHD = _MaHD;
            MaNV = _MaNV;
            NgayXuat = _NgayXuat;
            MaKH = _MaKH;
            TenKH = _TenKH;
            TenThuoc = _TenThuoc;
            SoLuong = _SL;
            DonViTinh = _DVT;
            Gia = _Gia;
            ThanhTien = _ThanhTien;
            TongTien = _TongTien;
        }
    }
}
