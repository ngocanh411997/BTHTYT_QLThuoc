using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLThuoc.DAL;
using QLThuoc.models;

namespace QLThuoc.BUS
{
   public class ThuocBUS
    {
        ThuocDAL da = new ThuocDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMaT()
        {
            return da.TangMaT();
        }
        public int InsertData(Thuoc T)
        {
            return da.InsertData(T);
        }
        public int UpdateData(Thuoc T)
        {
            return da.UpdateData(T);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemThuoc(string strTimKiem)
        {
            return da.TimKiemThuoc(strTimKiem);
        }
    }
}
