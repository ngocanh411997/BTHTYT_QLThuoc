using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
   public class CoSo
    {
        public string MaCS { get; set; }
        public string TenCS { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
       
        public CoSo()
        {
            MaCS = "";
            TenCS = "";
            DiaChi = "";
            SDT = "";
        }
        public CoSo(string _MaCS, string _TenCS, string _DiaChi, string _SDT)
        {
            MaCS = _MaCS;
            TenCS = _TenCS;
            DiaChi = _DiaChi;
            SDT = _SDT;
        }
    }
}
