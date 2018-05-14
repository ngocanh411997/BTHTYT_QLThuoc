using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLThuoc.DAL;

namespace QLThuoc.BUS
{
    class LoginBUS
    {
        LoginDAL DAL = new LoginDAL();
        public SqlDataAdapter BUSLogin(string ID, string Pass)
        {
            return DAL.DAL_Login(ID, Pass);
        }
    }
}
