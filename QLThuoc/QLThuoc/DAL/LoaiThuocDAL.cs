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
    public class LoaiThuocDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_LoaiThuoc", null);
        }
        public int InsertData(LoaiThuoc LT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiThuoc",LT.MaLoaiThuoc),
                new SqlParameter("TenLoaiThuoc",LT.TenLoaiThuoc),
                new SqlParameter("GhiChu",LT.GhiChu)
                
            };
            return conn.ExcuteSQL("Them_LoaiThuoc", para);
        }
        public int UpdateData(LoaiThuoc LT)
        {

            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiThuoc",LT.MaLoaiThuoc),
                new SqlParameter("TenLoaiThuoc",LT.TenLoaiThuoc),
                new SqlParameter("GhiChu",LT.GhiChu)
               
            };
            return conn.ExcuteSQL("Sua_LoaiThuoc", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaLoaiThuoc",ID)
        };
            return conn.ExcuteSQL("Xoa_LoaiThuoc", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From LoaiThuoc", "LT");
        }
        public DataTable TimKiemLoaiThuoc(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
    }
}
