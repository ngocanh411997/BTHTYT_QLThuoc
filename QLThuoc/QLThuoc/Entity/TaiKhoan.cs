using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLThuoc.Entity
{
    public class TaiKhoan
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public TaiKhoan()
        {
            Name = "";
            Pass = "";
        }
        public TaiKhoan(string _name, string _pass)
        {
            Name = _name;
            Pass = _pass;
        }

    }
}
