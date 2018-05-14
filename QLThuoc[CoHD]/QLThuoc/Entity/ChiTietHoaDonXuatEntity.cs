using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class ChiTietHoaDonXuatEntity
    {
        public string MaHDX { get; set;}
        public string MaThuoc { get; set; }
        public string DonViTinh { get; set; }
        public long Gia { get; set; }
        public int SoLuong { get; set;}
        public int ThanhTien { get; set; }

        public ChiTietHoaDonXuatEntity()
        {
            MaHDX = "";
            MaThuoc = "";
            DonViTinh = "";
            Gia = 0;
            SoLuong = 0;
            ThanhTien = 0;
        }     
        public ChiTietHoaDonXuatEntity(string _MaHDX, string _MaThuoc, string _DonViTinh, long _Gia, int _SoLuong, int _ThanhTien)
        {
            MaHDX = _MaHDX;
            MaThuoc = _MaThuoc;
            DonViTinh = _DonViTinh;
            Gia = _Gia;
            SoLuong = _SoLuong;
            ThanhTien = _ThanhTien;
        }
    }
}
