﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set;}
        public string SDT { get; set; }
        
        public KhachHang()
        {
            MaKH = "";
            TenKH = "";
            DiaChi = "";
            SDT = "";
        }
        public KhachHang(string _MaKH, string _TenKH, string _DiaChi, string _SDT)
        {
            MaKH = _MaKH;
            TenKH = _TenKH;
            DiaChi = _DiaChi;
            SDT = _SDT;
        }
    }
}
