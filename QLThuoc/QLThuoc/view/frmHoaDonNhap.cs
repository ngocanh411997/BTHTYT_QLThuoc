using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Entity;
using QLThuoc.models;

namespace QLThuoc.view
{
    public partial class frmHoaDonNhap : Form
    {
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        HoaDonNhap obj = new HoaDonNhap();
        private int fluu = 1;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            dgvHDNhap.DataSource = BUS.GetData();
        }
        public void Show_NCC()
        {
            DataTable dt = new DataTable();
            dt = BUS.Show_NCC();
            cbMaNCC.DataSource = dt;
            cbMaNCC.DisplayMember = "TenNCC";
            cbMaNCC.ValueMember = "MaNCC";
        }
        public void Show_NV()
        {
            DataTable dt = new DataTable();
            dt = BUS.Show_NV();
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
        }
        public void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaHD.Enabled = e;
            cbMaNCC.Enabled = e;
            cbMaNV.Enabled = e;
            dtNgayNhap.Enabled = e;
        }
        public void Clear()
        {
            txtMaHD.Text = "";
            cbMaNCC.Text = "";
            cbMaNV.Text = "";
            dtNgayNhap.Text = "";
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            Show_NCC();
            Show_NV();
        }


        private void dgvHoaDonNhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaHD.Text = BUS.TangMa();
            DisEnl(true);
            txtMaHD.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaHD.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nhân viên xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtNgayNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj.MaHoaDon = txtMaHD.Text;
            obj.MaNCC = cbMaNCC.SelectedValue.ToString();
            obj.MaNVNhap = cbMaNV.SelectedValue.ToString();
            obj.NgayNhap = dtNgayNhap.Value;


            if (txtMaHD.Text != "" && cbMaNCC.Text != "" && cbMaNV.Text != "" && dtNgayNhap.Text != "" && fluu == 0)
            {
                try
                {
                    BUS.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonNhap_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaHD.Text != "" && cbMaNCC.Text != "" && cbMaNV.Text != "" && dtNgayNhap.Text != "" && fluu != 0)
            {
                try
                {
                    BUS.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonNhap_Load(sender, e);
                    Clear();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BUS.DeleteData(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công!");
                    Clear();
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

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã HĐ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frm_ChiTietHoaDonNhap CT = new frm_ChiTietHoaDonNhap();
                CT.ShowDialog();
                this.Show();
            }
        }

        private void dgvHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                cbMaNCC.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ma_NCC"].Value);
                cbMaNV.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ma_NV"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ngay_Nhap"].Value);
            }
            else if (fluu != 0 && fluu != -1)
            {
                txtMaHD.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ma_HD"].Value);
                cbMaNCC.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ma_NCC"].Value);
                cbMaNV.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ma_NV"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvHDNhap.CurrentRow.Cells["Ngay_Nhap"].Value);

            }
        }

        private void dgvHDNhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHDNhap.Rows[e.RowIndex].Cells["sott"].Value = e.RowIndex + 1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Phiếu")
            {
                dgvHDNhap.DataSource = BUS.TimKiemHDN("select hd.MaHoaDon, TenNCC, NgayNhap,hd.MaNVNhap ,hd.TrangThai from HoaDonNhap hd , NhaCungCap where hd.MaNCC = NhaCungCap.MaNCC and MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%'and TrangThai=N'Chưa thanh toán'");
            }
            if(cbTimKiem.Text =="Nhà Cung Cấp")
            {
                dgvHDNhap.DataSource = BUS.TimKiemHDN("select hd.MaHoaDon, TenNCC, NgayNhap,hd.MaNVNhap ,hd.TrangThai from HoaDonNhap hd , NhaCungCap where hd.MaNCC = NhaCungCap.MaNCC and TenNCC like N'%" + txtTimKiem.Text.Trim() + "%'and TrangThai=N'Chưa thanh toán'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHDNhap.DataSource = BUS.TimKiemHDN("select hd.MaHoaDon, TenNCC, NgayNhap,hd.MaNVNhap ,hd.TrangThai from HoaDonNhap hd , NhaCungCap where hd.MaNCC = NhaCungCap.MaNCC and MaNVNhap like '%" + txtTimKiem.Text.Trim() + "%'and TrangThai=N'Chưa thanh toán'");
            }
            if (cbTimKiem.Text == "Ngày Nhập(năm-tháng-ngày)")
            {
                dgvHDNhap.DataSource = BUS.TimKiemHDN("select hd.MaHoaDon, TenNCC, NgayNhap,hd.MaNVNhap ,hd.TrangThai from HoaDonNhap hd , NhaCungCap where hd.MaNCC = NhaCungCap.MaNCC and hd.NgayNhap like '%" + txtTimKiem.Text.Trim() + "%'and TrangThai=N'Chưa thanh toán'");
            }
        }
    }
}

