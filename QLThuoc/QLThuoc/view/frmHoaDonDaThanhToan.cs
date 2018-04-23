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
            dgvHoaDonXuat.DataSource = Bus.XemHoaDonTT();
            dgvHoaDonXuat.AutoResizeColumns();
        }
        private void HienThiCT()
        {
            dgvChiTietHDX.DataSource = Bus.DataCTHDX("SELECT MaHDX,MaThuoc,DonViTinh,Gia,SoLuong,ThanhTien=(Gia*SoLuong) FROM dbo.ChiTietHoaDonXuat WHERE MaHDX LIKE '%" + txtHoaDon.Text.Trim() + "%'");
            dgvChiTietHDX.AutoResizeColumns();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmQuanLyChung QL = new frmQuanLyChung();
                QL.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoaDon.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaHoaDon"].Value);
            HienThiCT();
        }

        private void dgvHoaDonXuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDonXuat.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietHDX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDX.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
            txtHoaDon.Enabled = false;
        }

        private void frmHoaDonDaThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
            txtHoaDon.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã HĐ")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%' and TrangThai=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaKH like '%" + txtTimKiem.Text.Trim() + "%' and TrangThai=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaNVXuat Like '%" + txtTimKiem.Text.Trim() + "%' and TrangThai=N'Đã thanh toán'");
            }
            if (cbTimKiem.Text == "Ngày Nhập")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where NgayXuat like '%" + txtTimKiem.Text.Trim() + "%' and TrangThai=N'Đã thanh toán'");
            }
        }
    }
}
