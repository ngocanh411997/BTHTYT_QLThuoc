using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLThuoc.DAL;
using QLThuoc.Entity;

namespace QLThuoc.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL DAL = new TaiKhoanDAL();
        public int ThemTK(TaiKhoan TK)
        {
            return DAL.ThemTK(TK);
        }
    }
}
