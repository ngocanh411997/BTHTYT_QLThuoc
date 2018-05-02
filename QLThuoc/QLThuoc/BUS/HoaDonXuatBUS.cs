using QLThuoc.DAL;
using QLThuoc.Entity;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.BUS
{
    public class HoaDonXuatBUS
    {
        HoaDonXuatDAL da = new HoaDonXuatDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public int InsertData(HoaDonXuatEntity HDX)
        {
            return da.InsertData(HDX);
        }
        public int UpdateData(HoaDonXuatEntity HDX)
        {
            return da.UpdateData(HDX);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public DataTable TimKiemHDX(string strTimKiem)
        {
            return da.TimKiemHDX(strTimKiem);
        }
        //////////////////////////
        public DataTable DataCTHDX(string strCTHDX)
        {
            return da.DataCTHDX(strCTHDX);
        }
        public int InsertDataCT(ChiTietHoaDonXuatEntity CTHDX)
        {
            return da.InsertDataCT(CTHDX);
        }
        public int UpdateDataCT(ChiTietHoaDonXuatEntity CTHDX)
        {
            return da.UpdateDataCT(CTHDX);
        }
        public int DeleteDataCT(string IDHD,string IDT)
        {
            return da.DeleteDataCT(IDHD,IDT);
        }
        //
        public DataTable GetListT(string str)
        {
            return da.GetListT(str);
        }
        //
        public DataTable ThanhToan(string str)
        {
            return da.ThanhToan( str);
        }
        public int UpdateDataTT(HoaDonXuatEntity HDX)
        {
            return da.UpdateDataTT(HDX);
        }
        //
        public DataTable GetDataHoaDonTT()
        {
            return da.GetDataHoaDonTT();
        }
    }
}
