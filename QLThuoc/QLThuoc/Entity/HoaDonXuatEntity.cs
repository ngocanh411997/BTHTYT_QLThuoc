using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Entity
{
    public class HoaDonXuatEntity
    {
        public string MaHoaDon { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaNVXuat { get; set; }

        public HoaDonXuatEntity()
        {
            MaHoaDon = "";
            MaKH = "";
            NgayXuat = DateTime.Parse("01/01/1997");
            MaNVXuat = "";
        }
        public HoaDonXuatEntity(string _MaHoaDon, string _MaKH, DateTime _NgayXuat, string _MaNVXuat)
        {
            MaHoaDon = _MaHoaDon;
            MaKH = _MaKH;
            NgayXuat = _NgayXuat;
            MaNVXuat = _MaNVXuat;
        }
    }

}
