using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLThuoc.Tool;

namespace QLThuoc.DAL
{
    class LoginDAL
    {
        SqlConnection conn = String_SQLConn.StringSQL();
        public SqlDataAdapter DAL_Login(string ID, string Pass)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where Name = '" + ID + "' and Pass = '" + Pass + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
    }
}
