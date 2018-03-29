using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class ChiTietHoaDonXuat
    {
        public string MaCTHDX { get; set;}
        public string MaThuoc { get; set; }
        public string DonViTinh { get; set; }
        public long Gia { get; set; }
        public int SoLuong { get; set;} 
        
        public ChiTietHoaDonXuat()
        {
            MaCTHDX = "";
            MaThuoc = "";
            DonViTinh = "";
            Gia = 0;
        }     
    }
}
