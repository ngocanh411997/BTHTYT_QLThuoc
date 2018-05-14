using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLThuoc.Entity;


namespace QLThuoc.DAL
{
   public class TaiKhoanDAL
    {
        KetNoi conn = new KetNoi();
        public int ThemTK(TaiKhoan TK)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Name",TK.Name),
                new SqlParameter("Pass",TK.Pass)
            };
            return conn.ExcuteSQL("Them_TK", para);
        }
    }
}
