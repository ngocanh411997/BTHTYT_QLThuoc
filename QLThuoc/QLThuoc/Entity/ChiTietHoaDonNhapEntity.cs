using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Entity
{
    public class ChiTietHoaDonNhapEntity
    {
        public string MaHDN { get; set; }
        public string MaThuoc { get; set; }
        public string DonViTinh { get; set; }
        public long Gia { get; set; }
        public int SoLuong { get; set; }

        public ChiTietHoaDonNhapEntity()
        {
            MaHDN = "";
            MaThuoc = "";
            DonViTinh = "";
            Gia = 0;
            SoLuong = 0;
        }
        public ChiTietHoaDonNhapEntity(string _MaHDN, string _MaThuoc, string _DonViTinh, long _Gia, int _SoLuong)
        {
            MaHDN = _MaHDN;
            MaThuoc = _MaThuoc;
            DonViTinh = _DonViTinh;
            Gia = _Gia;
            SoLuong = _SoLuong;
        }
    }
}
