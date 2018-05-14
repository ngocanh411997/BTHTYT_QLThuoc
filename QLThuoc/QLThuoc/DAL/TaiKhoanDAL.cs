using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLThuoc.Entity;
using System.Data;
using System.Data.SqlClient;

namespace QLThuoc.DAL
{
    class TaiKhoanDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_TK", null);
        }
        public int ThemTK(TaiKhoan TK)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Name",TK.Name),
                new SqlParameter("Pass",TK.Pass),
                

            };
            return conn.ExcuteSQL("Them_TK", para);
        }
    }
}
