using QLThuoc.BUS;
using QLThuoc.models;
using QLThuoc.Entity;
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
    public partial class frm_ChiTietHoaDonNhap : Form
    {
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        ChiTietHoaDonNhapEntity CT = new ChiTietHoaDonNhapEntity();
        private int fluu = 1;
        public frm_ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        string ma = "";
        public frm_ChiTietHoaDonNhap(string text):this()
        {
            ma = text;

        }
        public void ShowTenThuoc()
        {
            DataTable dt = new DataTable();
            dt = BUS.ShowTenThuoc("select MaThuoc, TenThuoc from Thuoc");
            cbTenThuoc.DataSource = dt;
            cbTenThuoc.DisplayMember = "TenThuoc";
            cbTenThuoc.ValueMember = "MaThuoc";

        }
        private void DisEnl(bool e)
        {
            btnThemCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            btnSuaCT.Enabled = !e;
            btnLuuCT.Enabled = e;
            btnHuy.Enabled = e;
            txtSoLuong.Enabled = e;
            cbTenThuoc.Enabled = e;
            cbDonViTinh.Enabled = e;
            txtGia.Enabled = e;
        }
        private void HienThi()
        {
            txt_MaHD.Text = ma;
            dgvChiTietHDN.DataSource = BUS.Xem_CTHDN("SELECT MaHDN,TenThuoc, DonViTinh,ChiTietHoaDonNhap.SoLuong,Gia,ThanhTien FROM dbo.HoaDonNhap INNER JOIN dbo.ChiTietHoaDonNhap ON ChiTietHoaDonNhap.MaHDN = HoaDonNhap.MaHoaDon INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonNhap.MaThuoc WHERE MaHDN = '" + txt_MaHD.Text + "' and TrangThai=N'Chưa thanh toán'");
            txt_MaHD.Enabled = false;
            ShowTenThuoc();
        }


        private void btnDSCT_Click(object sender, EventArgs e)
        {
           dgvChiTietHDN.DataSource = BUS.Xem_CTHDN("SELECT MaHDN,TenThuoc, DonViTinh,ChiTietHoaDonNhap.SoLuong,Gia,ThanhTien from ChiTietHoaDonNhap, HoaDonNhap, Thuoc where ChiTietHoaDonNhap.MaHDN = HoaDonNhap.MaHoaDon and Thuoc.MaThuoc = ChiTietHoaDonNhap.MaThuoc and TrangThai = N'Chưa thanh toán'");
            DisEnl(true);
            txt_MaHD.Enabled = false;
            btnLuuCT.Enabled = false;
            ShowTenThuoc();
        }

        private void dgvChiTietHDN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDN.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void frm_ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvChiTietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbTenThuoc.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["TenThuoc"].Value);
            txtSoLuong.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["SoLuong"].Value);
            txtGia.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["Gia"].Value);
            cbDonViTinh.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["DonViTinh"].Value);
        }
        

        //chức năng
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
            txt_MaHD.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txt_MaHD.Enabled = false;
            cbTenThuoc.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BUS.XoaCT(txt_MaHD.Text, cbTenThuoc.SelectedValue.ToString());
                    MessageBox.Show("Xóa thành công!");
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txt_MaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã HĐ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thuốc! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            int _gia;
            int.TryParse(txtGia.Text, out _gia);

            CT.MaThuoc = cbTenThuoc.SelectedValue.ToString();
            CT.MaHDN = txt_MaHD.Text;
            CT.SoLuong = _soLuong;
            CT.Gia = _gia;
           CT.DonViTinh = cbDonViTinh.Text;

            if (txt_MaHD.Text != "" && txtSoLuong.Text != "" && cbDonViTinh.Text != "" && cbTenThuoc.Text != "" && txtGia.Text != "" && fluu == 0)
            {
                try
                {
                    BUS.ThemCT(CT);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frm_ChiTietHoaDonNhap_Load(sender, e);
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txt_MaHD.Text != "" && txtSoLuong.Text != "" && cbDonViTinh.Text != "" && cbTenThuoc.Text != "" && txtGia.Text != "" && fluu != 0)
            {
                try
                {
                    BUS.SuaCT(CT);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frm_ChiTietHoaDonNhap_Load(sender, e);
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnChiPhi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiPhi ChiPhi = new frmChiPhi(txt_MaHD.Text);
            ChiPhi.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
                
        }
    }
}
