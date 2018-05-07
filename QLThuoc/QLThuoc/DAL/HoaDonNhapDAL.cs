using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLThuoc.Entity;
using QLThuoc.models;

namespace QLThuoc.DAL
{
    public class HoaDonNhapDAL
    {
        KetNoi conn = new KetNoi();

        // Hóa đơn
        public DataTable GetData()
        {
            return conn.GetData("Xem_HDN", null);
        }
        public DataTable Show_NCC()
        {
            return conn.GetData("Show_NCC", null);
        }
        public DataTable Show_NV()
        {
            return conn.GetData("Show_NV", null);
        }


        public int InsertData(HoaDonNhap HDN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDN",HDN.MaHoaDon),
                new SqlParameter("MaNCC",HDN.MaNCC),
                new SqlParameter("NgayNhap",HDN.NgayNhap),
                new SqlParameter("MaNVNhap",HDN.MaNVNhap),
                new SqlParameter("TrangThai", HDN.TrangThai)
            };
            return conn.ExcuteSQL("Them_HDN", para);
        }
        public int UpdateData(HoaDonNhap HDN)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaHDN",HDN.MaHoaDon),
                new SqlParameter("MaNCC",HDN.MaNCC),
                new SqlParameter("NgayNhap",HDN.NgayNhap),
                new SqlParameter("MaNVNhap",HDN.MaNVNhap),
                 new SqlParameter("TrangThai", HDN.TrangThai)
        };
            return conn.ExcuteSQL("Sua_HDN", para);
        }

        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDN",ID)
        };
            return conn.ExcuteSQL("Xoa_HDN", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From HoaDonNhap", "DN");
        }
        public DataTable TimKiemHDN(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }

        // Chi tiết hóa đơn nhập

    }
}
