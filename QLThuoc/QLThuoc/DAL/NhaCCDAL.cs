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
   public class NhaCCDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_NhaCungCap", null);
        }
        public int InsertData(NhaCC NCC)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC",NCC.MaNCC),
                new SqlParameter("TenNCC",NCC.TenNCC),
                new SqlParameter("DiaChi",NCC.DiaChi),
                new SqlParameter ("SDT",NCC.SDT)
            };
            return conn.ExcuteSQL("Them_NhaCungCap", para);
        }
        public int UpdateData(NhaCC NCC)
        {
            SqlParameter[] para =
            {
              new SqlParameter("MaNCC",NCC.MaNCC),
                new SqlParameter("TenNCC",NCC.TenNCC),
                new SqlParameter("DiaChi",NCC.DiaChi),
                new SqlParameter ("SDT",NCC.SDT)
            };
            return conn.ExcuteSQL("Sua_NhaCungCap", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNCC",ID)
        };
            return conn.ExcuteSQL("Xoa_NhaCungCap", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhaCungCap", "NCC");
        }
        public DataTable TimKiemNCC(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
