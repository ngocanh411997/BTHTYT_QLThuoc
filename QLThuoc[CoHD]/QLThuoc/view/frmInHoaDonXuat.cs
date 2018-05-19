using CrystalDecisions.CrystalReports.Engine;
using QLThuoc.DAL;
using QLThuoc.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLThuoc.view
{
    public partial class frmInHoaDonXuat : Form
    {
        public frmInHoaDonXuat()
        {
            InitializeComponent();
        }
        KetNoi dblayer = new KetNoi();
        ReportDocument cry = new ReportDocument();
        string ma;
        public frmInHoaDonXuat(string text):this()
        {
            ma = text;
        }
        private void frmInHoaDonXuat_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = ma;
            txtMaHD.Enabled = false;
            List<HoaDon> _List = new List<HoaDon>();
            DataSet ds1 = dblayer.HD1("SELECT TenThuoc,SoLuong,DonViTinh,Gia,ThanhTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc WHERE MaHDX='"+txtMaHD.Text+"'");
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                _List.Add(new HoaDon
                {
                    TenThuoc = dr["TenThuoc"].ToString(),                   
                    SoLuong = Convert.ToInt32(dr["SoLuong"].ToString()),
                    DonViTinh = dr["DonViTinh"].ToString(),
                    Gia = Convert.ToInt32(dr["Gia"].ToString()),
                    ThanhTien = Convert.ToInt32(dr["ThanhTien"].ToString())
                });
            }

            cry.Load(@"C:\Users\NgocAnh\Documents\GitHub\BTHTYT_QLThuoc1\QLThuoc[CoHD]\QLThuoc\view\InHoaDonXuat.rpt");
            cry.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = cry;
            //
            DataSet ds2 = dblayer.HD2("SELECT MaHDX, MaNVXuat, NgayXuat, HoaDonXuat.MaKH, TenKH, SUM(ThanhTien) AS TongTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX INNER JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDonXuat.MaKH WHERE MaHDX = '"+txtMaHD.Text+"' GROUP BY MaHDX, MaNVXuat, NgayXuat, HoaDonXuat.MaKH, TenKH");
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                inHoaDonXuat1.SetDataSource(_List);
                inHoaDonXuat1.SetParameterValue("PMaHD", dr["MaHDX"].ToString());
                inHoaDonXuat1.SetParameterValue("PNhanVien", dr["MaNVXuat"].ToString());
                inHoaDonXuat1.SetParameterValue("PNgay", dr["NgayXuat"].ToString());
                inHoaDonXuat1.SetParameterValue("PMaKH", dr["MaKH"].ToString());
                inHoaDonXuat1.SetParameterValue("PTenKH", dr["TenKH"].ToString());
                inHoaDonXuat1.SetParameterValue("PTongTien", Convert.ToInt32(dr["TongTien"].ToString()));
            }
            crystalReportViewer1.ReportSource = inHoaDonXuat1;
        }
    }
}
