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
    public class ThuocDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_Thuoc", null);
        }
        public int InsertData(Thuoc T)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaThuoc",T.MaThuoc),
                new SqlParameter("TenThuoc",T.TenThuoc),
                new SqlParameter("MaLoaiThuoc",T.MaLoaiThuoc),
                new SqlParameter ("MaDVSX",T.MaDVSX),
                new SqlParameter("CongDung",T.CongDung),
                new SqlParameter("HSD",T.HSD),
                new SqlParameter("NuocSX",T.NuocSX)
            };
            return conn.ExcuteSQL("Them_Thuoc", para);
        }
        public int UpdateData(Thuoc T)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaThuoc",T.MaThuoc),
                new SqlParameter("TenThuoc",T.TenThuoc),
                new SqlParameter("MaLoaiThuoc",T.MaLoaiThuoc),
                new SqlParameter ("MaDVSX",T.MaDVSX),
                new SqlParameter("CongDung",T.CongDung),
                new SqlParameter("HSD",T.HSD),
                new SqlParameter("NuocSX",T.NuocSX)
            };
            return conn.ExcuteSQL("Sua_Thuoc", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaThuoc",ID)
        };
            return conn.ExcuteSQL("Xoa_Thuoc", para);
        }
        public string TangMaT()
        {
            return conn.TangMaT("Select * From Thuoc", "T");
        }
        public DataTable TimKiemThuoc(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
