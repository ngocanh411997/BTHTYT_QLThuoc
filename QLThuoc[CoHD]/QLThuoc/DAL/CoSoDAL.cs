using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.DAL
{
   public class CoSoDAL
    {

        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_CoSo", null);
        }
        public int InsertData(CoSo CS)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaCS",CS.MaCS),
                new SqlParameter("TenCS",CS.TenCS),
                new SqlParameter("DiaChi",CS.DiaChi),
                new SqlParameter ("SDT",CS.SDT)
            };
            return conn.ExcuteSQL("Them_CoSo", para);
        }
        public int UpdateData(CoSo CS)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaCS",CS.MaCS),
                new SqlParameter("TenCS",CS.TenCS),
                new SqlParameter("DiaChi",CS.DiaChi),
                new SqlParameter ("SDT",CS.SDT)
        };
            return conn.ExcuteSQL("Sua_CoSo", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaCS",ID)
        };
            return conn.ExcuteSQL("Xoa_CoSo", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From CoSo", "CS");
        }
        public DataTable TimKiemCS(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
