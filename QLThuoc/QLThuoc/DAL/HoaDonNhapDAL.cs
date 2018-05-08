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

        public DataTable Xem_CTHDN(string str)
        {
            return conn.GetData(str);
        }

      
        public DataTable ShowTenThuoc(string str)
        {
            return conn.GetData(str);
        }
        // thêm chi tiết hóa đơn
        public int ThemCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            SqlParameter[] para =
           {
                new SqlParameter("MaHDN",CTHDN.MaHDN),
                new SqlParameter("MaThuoc",CTHDN.MaThuoc),
                new SqlParameter("DVT",CTHDN.DonViTinh),
                new SqlParameter("SoLuong",CTHDN.SoLuong),
                new SqlParameter("Gia",CTHDN.Gia),
                new SqlParameter("ThanhTien",CTHDN.ThanhTien)

            };

            return conn.ExcuteSQL("Them_CTHDN",para);
        }

        // sửa chi tiết hóa đơn
        public int SuaCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            SqlParameter[] para =
          {
                new SqlParameter("MaHDN",CTHDN.MaHDN),
                new SqlParameter("MaThuoc",CTHDN.MaThuoc),
                new SqlParameter("DVT",CTHDN.DonViTinh),
                new SqlParameter("SoLuong",CTHDN.SoLuong),
                new SqlParameter("Gia",CTHDN.Gia),
                new SqlParameter("ThanhTien",CTHDN.ThanhTien)

            };
            return conn.ExcuteSQL("Sua_CTHDN", para);
        }

        // xóa chi tiết hóa đơn
        public int XoaCT(string IDHD, string IDCT)
        {
            SqlParameter[] para =
          {
                new SqlParameter("MaHDN",IDHD),
                new SqlParameter("MaThuoc",IDCT)
            };
            return conn.ExcuteSQL("Xoa_CTHDN", para);
        }

        // tính chi phí cho hóa đơn
        public DataTable TinhChiPhi(string str)
        {
            return conn.GetData(str);
        }

        // Update lại trạng thái cho hóa đơn sau khi đã tính chi phí
        public int Update_ChiPhi(HoaDonNhap HDN)
        {

            SqlParameter[] para =
           {
               new SqlParameter("MaHoaDon",HDN.MaHoaDon),
                new SqlParameter("TrangThai",HDN.TrangThai)
            };
            return conn.ExcuteSQL("SuaTrangThai", para);
        }


        // Xem những hóa đơn đã trả chi phí
        public DataTable Xem_ChiPhi(HoaDonNhap HDN)
        {
            return conn.GetData("Xem_ChiPhi", null);
        }

    }
}
