using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class NhanVienEntity
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaCS { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string TenCS { get; set; }

        public NhanVienEntity()
        {
            MaNV = "";
            TenNV = "";
            MaCS = "";
            GioiTinh = "";
            NgaySinh = DateTime.Parse("01/01/1997");
            SDT = "";
            DiaChi = "";
            TenCS = "";          
        }
        public NhanVienEntity(string _MaNV, string _TenNV, string _MaCS, string _GioiTinh, DateTime _NgaySinh, string _SDT, string _DiaChi,string _TenCS)
        {
            MaNV = _MaNV;
            TenNV = _TenNV;
            MaCS = _MaCS;
            GioiTinh = _GioiTinh;
            NgaySinh = _NgaySinh;
            SDT = _SDT;
            DiaChi = _DiaChi;
            TenCS = _TenCS;
        }
    }
   
}
