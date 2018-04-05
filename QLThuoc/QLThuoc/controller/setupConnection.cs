using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.controller
{
    public class setupConnection
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        public static class ConnectionString
        {
            public static string Connection = "Data Source=NGOCANH\\NGOCANH;Initial Catalog=QLGV_HS_THPT;Integrated Security=True";
        }
    }
}
