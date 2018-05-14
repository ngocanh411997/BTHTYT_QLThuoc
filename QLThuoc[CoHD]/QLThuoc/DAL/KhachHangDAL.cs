using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLThuoc.models;


namespace QLThuoc.DAL
{
   public class KhachHangDAL
    {

        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_KhachHang", null);
        }
        public int InsertData(KhachHang KH)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",KH.MaKH),
                new SqlParameter("TenKH",KH.TenKH),
                new SqlParameter("DiaChi",KH.DiaChi),
                new SqlParameter ("SDT",KH.SDT)
            };
            return conn.ExcuteSQL("Them_KhachHang", para);
        }
        public int UpdateData(KhachHang KH)
        {
            SqlParameter[] para =
            {
              new SqlParameter("MaKH",KH.MaKH),
                new SqlParameter("TenKH",KH.TenKH),
                new SqlParameter("DiaChi",KH.DiaChi),
                new SqlParameter ("SDT",KH.SDT)
        };
            return conn.ExcuteSQL("Sua_KhachHang", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaKH",ID)
        };
            return conn.ExcuteSQL("Xoa_KhachHang", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From KhachHang", "KH");
        }
        public DataTable TimKiemKH(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
      }
}
