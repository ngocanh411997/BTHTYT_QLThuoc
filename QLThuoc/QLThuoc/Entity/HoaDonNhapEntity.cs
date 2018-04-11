using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class HoaDonNhap
    {
        public string MaHoaDon { get; set; }
        public string MaNCC { get; set; }      
        public DateTime NgayNhap { get; set; }
        public string MaNVNhap { get; set; }

        public HoaDonNhap()
        {
            MaHoaDon = "";
            MaNCC = "";
            NgayNhap = DateTime.Parse("01/01/2017");
            MaNVNhap = "";
        }
        public HoaDonNhap(string _MaHoaDon, string _MaNCC, DateTime _NgayNhap, string _MaNVNhap)
        {
            MaHoaDon = _MaHoaDon;
            MaNCC = _MaNCC;
            NgayNhap = _NgayNhap;
            MaNVNhap = _MaNVNhap;
        }
    }
}
