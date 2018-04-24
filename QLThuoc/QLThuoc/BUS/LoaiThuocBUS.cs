using QLThuoc.DAL;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.BUS
{
    public class LoaiThuocBUS
    {
        LoaiThuocDAL da = new LoaiThuocDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(LoaiThuoc LT)
        {
            return da.InsertData(LT);
        }
        public int UpdateData(LoaiThuoc LT)
        {
            return da.UpdateData(LT);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemLoaiThuoc(string strTimKiem)
        {
            return da.TimKiemLoaiThuoc(strTimKiem);
        }
    }
}
