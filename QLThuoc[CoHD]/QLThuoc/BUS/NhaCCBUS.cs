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
   public class NhaCCBUS
    {
        NhaCCDAL da = new NhaCCDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(NhaCC NCC)
        {
            return da.InsertData(NCC);
        }
        public int UpdateData(NhaCC NCC)
        {
            return da.UpdateData(NCC);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemNCC(string strTimKiem)
        {
            return da.TimKiemNCC(strTimKiem);
        }
    }
}
