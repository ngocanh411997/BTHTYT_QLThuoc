using System;
using QLThuoc.DAL;
using QLThuoc.models;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.BUS
{
    public class KhachHangBUS
    {
        KhachHangDAL da = new KhachHangDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }

        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(KhachHang KH)
        {
            return da.InsertData(KH);
        }
        public int UpdateData(KhachHang KH)
        {
            return da.UpdateData(KH);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemKH(string strTimKiem)
        {
            return da.TimKiemKH(strTimKiem);
        }

    }
}
