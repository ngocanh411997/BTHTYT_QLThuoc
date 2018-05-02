using QLThuoc.BUS;
using QLThuoc.Entity;
using QLThuoc.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuoc.view
{
    public partial class frmHoaDonDaThanhToan : Form
    {
        HoaDonXuatEntity obj = new HoaDonXuatEntity();
        ChiTietHoaDonXuatEntity CT = new ChiTietHoaDonXuatEntity();
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public frmHoaDonDaThanhToan()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvHoaDon.DataSource = Bus.GetDataHoaDonTT();
            dgvHoaDon.AutoResizeColumns();
        }
        private void HienThiCT()
        {
            dgvChiTietHDX.DataSource = Bus.DataCTHDX("SELECT MaHDX,TenThuoc,DonViTinh,Gia,ChiTietHoaDonXuat.SoLuong,ThanhTien FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc where MaHDX like '%" + txtMaHD.Text.Trim() + "%'");
            dgvChiTietHDX.AutoResizeColumns();
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

        private void dgvChiTietHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvChiTietHDX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDX.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void frmHoaDonDaThanhToan_Load(object sender, EventArgs e)
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
                dgvHoaDon.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Mã KH")
            {
                dgvHoaDon.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaKH like  '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Ngày Xuất")
            {
                dgvHoaDon.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where NgayXuat like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Mã NVX")
            {
                dgvHoaDon.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaNVXuat Like  '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Đã thanh toán'");
            }
        }
    }
}
