using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuoc.DAL;
using QLThuoc.Entity;
using QLThuoc.models;
using System.Data;



namespace QLThuoc.BUS
{
   public class HoaDonNhapBUS
    {


        HoaDonNhapDAL HDN_dal = new HoaDonNhapDAL();
        public string TangMa()
        {
            return HDN_dal.TangMa();
        }
        // Hóa đơn
        public DataTable GetData()
        {
            return HDN_dal.GetData();
        }
        public DataTable Show_NCC()
        {
            return HDN_dal.Show_NCC();
        }
        public DataTable Show_NV()
        {
            return HDN_dal.Show_NV();
        }
        public int InsertData(HoaDonNhap HDN)
        {
            return HDN_dal.InsertData(HDN);
        }
        public int UpdateData(HoaDonNhap HDN)
        {
            return HDN_dal.UpdateData(HDN);
        }
        public int DeleteData(string ID)
        {
            return HDN_dal.DeleteData(ID);
        }
        public DataTable TimKiemHDN(string strTimKiem)
        {
            return HDN_dal.TimKiemHDN(strTimKiem);
        }


    }
}
