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

        // chi tiết hóa đơn
        public DataTable GetCTHDN(string CTHDN)
        {
            return HDN_dal.GetCTHDN(CTHDN);
        }
        public int InsertDataCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            return HDN_dal.InsertDataCT(CTHDN);
        }
        public int UpdateDataCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            return HDN_dal.UpdateDataCT(CTHDN);
        }
        public int DeleteDataCT(string IDHD, string IDT)
        {
            return HDN_dal.DeleteDataCT(IDHD, IDT);
        }
        public DataTable TinhChiPhi(string str)
        {
            return HDN_dal.TinhChiPhi(str);
        }



    }
}
