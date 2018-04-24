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


        public int InsertData(HoaDonNhap HDN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDN",HDN.MaHoaDon),
                new SqlParameter("MaNCC",HDN.MaNCC),
                new SqlParameter("NgayNhap",HDN.NgayNhap),
                new SqlParameter("MaNVNhap",HDN.MaNVNhap)
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
                new SqlParameter("MaNVNhap",HDN.MaNVNhap)
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

        // Chi tiết hóa đơn
        public DataTable GetCTHDN(string CTHDN)
        {
            return conn.GetData(CTHDN);
        }

        public int InsertDataCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaHDN",CTHDN.MaHDN),
                new SqlParameter("MaThuoc",CTHDN.MaThuoc),
                new SqlParameter("DVT",CTHDN.DonViTinh),
                new SqlParameter("Gia",CTHDN.Gia),
               new SqlParameter("SoLuong",CTHDN.SoLuong),

            };
            return conn.ExcuteSQL("Them_CTHDN", para);
        }
        public int UpdateDataCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MaHDN",CTHDN.MaHDN),
                new SqlParameter("MaThuoc",CTHDN.MaThuoc),
                new SqlParameter("DVT",CTHDN.DonViTinh),
                new SqlParameter("Gia",CTHDN.Gia),
               new SqlParameter("SoLuong",CTHDN.SoLuong),
            };
            return conn.ExcuteSQL("Sua_CTHDN", para);
        }
        public int DeleteDataCT(string IDHD, string IDT)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaHDN",IDHD),
            new SqlParameter("MaThuoc", IDT),

        };
            return conn.ExcuteSQL("Xoa_CTHDN", para);
        }

        public DataTable TinhChiPhi(string str)
        {
            return conn.GetData(str);
        }

    }
}
