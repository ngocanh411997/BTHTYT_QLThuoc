using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.models
{
    public class LoaiThuoc
    {
        public string MaLoaiThuoc { get; set; }
        public string TenLoaiThuoc { get; set; }
        public string GhiChu { get; set; }

        public LoaiThuoc()
        {
            MaLoaiThuoc = "";
            TenLoaiThuoc = "";
            GhiChu = "";
        }
        public LoaiThuoc(string _MaLoaiThuoc, string _TenLoaiThuoc, string _GhiChu)
        {
            MaLoaiThuoc = _MaLoaiThuoc;
            TenLoaiThuoc = _TenLoaiThuoc;
            GhiChu = _GhiChu;
        }
    }
}
