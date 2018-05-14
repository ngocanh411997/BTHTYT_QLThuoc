using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Entity;
using QLThuoc.models;

namespace QLThuoc.view
{

    public partial class frmHoaDonDaTra : Form
    {
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        ChiTietHoaDonNhapEntity CT = new ChiTietHoaDonNhapEntity();
        HoaDonNhap HDN = new HoaDonNhap();

        public frmHoaDonDaTra()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvHoaDon.DataSource = BUS.Xem_ChiPhi(HDN);
            dgvHoaDon.AutoResizeColumns();
        }
        private void HienThiCT()
        {
            dgvChiTietHDN.DataSource = BUS.Xem_CTHDN("SELECT MaHDN,TenThuoc,DonViTinh,Gia,ChiTietHoaDonNhap.SoLuong,SUM (ThanhTien) AS TongTien FROM dbo.ChiTietHoaDonNhap INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonNhap.MaThuoc where MaHDN like '%" + txtMaHD.Text.Trim() + "%' GROUP BY MaHDN,TenThuoc,DonViTinh,Gia,ChiTietHoaDonNhap.SoLuong ");
            dgvChiTietHDN.AutoResizeColumns();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = Convert.ToString(dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value);
            HienThiCT();
        }

        private void dgvHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietHDN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDN.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void frmHoaDonDaTra_Load(object sender, EventArgs e)
        {
            HienThi();
            txtMaHD.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
            txtMaHD.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cbTimKiem.Text == "Mã HĐ")
            {
                dgvHoaDon.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Mã NCC")
            {
                dgvHoaDon.DataSource = BUS.TimKiemHDN("select * from  HoaDonNhap where MaNCC like  '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Ngày Nhập")
            {
                dgvHoaDon.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where NgayNhap like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Mã NVN")
            {
                dgvHoaDon.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where MaNVNhap Like  '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
        }
    }
}
