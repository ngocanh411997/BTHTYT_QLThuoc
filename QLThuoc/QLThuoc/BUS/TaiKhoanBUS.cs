using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLThuoc.DAL;
using QLThuoc.models;
using QLThuoc.Entity;

namespace QLThuoc.BUS
{
    class TaiKhoanBUS
    {
        TaiKhoanDAL DAL = new TaiKhoanDAL();
        public DataTable GetData()
        {
            return DAL.GetData();
        }
        public int ThemTK(TaiKhoan TK)
        {
            return DAL.ThemTK(TK);
        }
    }
}
