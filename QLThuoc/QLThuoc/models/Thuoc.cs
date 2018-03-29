using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class Thuoc
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string MaLoaiThuoc { get; set; }
        public string MaDVSX { get; set; }
        public string CongDung { get; set; }
        public string HSD { get; set; }
        public int SoLuong { get; set; }
        public string NuocSX { get; set; }
       
        public Thuoc()
        {
            MaThuoc = "";
            TenThuoc = "";
            MaLoaiThuoc = "";
            MaDVSX = "";
            CongDung = "";
            HSD = "";
            SoLuong = 0;
            NuocSX = "";
        }
        public Thuoc(string _MaThuoc, string _TenThuoc, string _MaLoaiThuoc, string _MaDVSX, string _CongDung, string _HSD, int _SoLuong, string _NuocSX)
        {
            MaThuoc = _MaThuoc;
            TenThuoc = _TenThuoc;
            MaLoaiThuoc = _MaLoaiThuoc;
            MaDVSX = _MaDVSX;
            CongDung = _CongDung;
            HSD = _HSD;
            SoLuong = _SoLuong;
            NuocSX = _NuocSX;
        }
    }
}
