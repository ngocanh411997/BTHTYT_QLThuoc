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

        // chi tiết hóa đơn
        public DataTable Xem_CTHDN(string str)
        {
            return HDN_dal.Xem_CTHDN(str);
        }
        public DataTable ShowTenThuoc(string str)
        {
            return HDN_dal.ShowTenThuoc(str);
        }
        public int ThemCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            return HDN_dal.ThemCT(CTHDN);
        }
        public int SuaCT(ChiTietHoaDonNhapEntity CTHDN)
        {
            return HDN_dal.SuaCT(CTHDN);
        }
        public int XoaCT(string IDHD, string IDCT)
        {
            return HDN_dal.XoaCT(IDHD,IDCT);
        }
        // tính chi phí cho hóa đơn
        public DataTable TinhChiPhi(string str)
        {
            return HDN_dal.TinhChiPhi(str);
        }
        // Update lại trạng thái cho hóa đơn sau khi đã tính chi phí
        public int Update_ChiPhi(HoaDonNhap HDN)
        {
            return HDN_dal.Update_ChiPhi(HDN);
        }
        // Xem những hóa đơn đã trả chi phí
        public DataTable Xem_ChiPhi(HoaDonNhap HDN)
        {
            return HDN_dal.Xem_ChiPhi(HDN);
        }
        // chi phí trong 1 ngày
        public DataTable ChiPhiNgay()
        {
            return HDN_dal.ChiPhiNgay();
        }
        // chi phí trong 1 tháng
        public DataTable ChiPhiThang()
        {
            return HDN_dal.ChiPhiThang();
        }
        // chi phí 1 năm
        public DataTable ChiPhiNam()
        {
            return HDN_dal.ChiPhiNam();
        }

    }
}
