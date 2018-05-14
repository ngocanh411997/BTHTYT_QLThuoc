using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class NhaCC
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public NhaCC()
        {
            MaNCC = "";
            TenNCC = "";
            SDT = "";
            DiaChi = "";
        }
        public NhaCC(string _MaNCC, string _TenNCC, string _SDT, string _DiaChi)
        {
            MaNCC = _MaNCC;
            TenNCC = _TenNCC;
            SDT = _SDT;
            DiaChi = _DiaChi;
        }
    }
}
