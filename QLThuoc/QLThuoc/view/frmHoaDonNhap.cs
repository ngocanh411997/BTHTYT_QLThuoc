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
        HoaDonNhap HDN = new HoaDonNhap();
        ChiTietHoaDonNhapEntity CT = new ChiTietHoaDonNhapEntity();
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        private int fluu = 1;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgayNhap.Enabled = e;
            txtMaHD.Enabled = e;
            txtMaNVNhap.Enabled = e;
            txtMaNCC.Enabled = e;
        }
        private void DisEnlCT(bool e)
        {
            btnThemCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            btnSuaCT.Enabled = !e;
            btnLuuCT.Enabled = e;
            btnHuy.Enabled = e;
            txt_MaHD.Enabled = e;
            txtMaThuoc.Enabled = e;
            txtSoLuong.Enabled = e;
            cbDonViTinh.Enabled = e;
            txtGia.Enabled = e;
        }
        private void clearData()
        {
            txtMaHD.Text = "";
            txtMaNCC.Text = "";
            txtMaNVNhap.Text = "";
            dtNgayNhap.Text = "";

        }
        private void HienThi()
        {
            dgvHoaDonNhap.DataSource = BUS.GetData();
        }
        private void HienThiCT()
        {
            dgvChiTietHDN.DataSource = BUS.GetCTHDN("select  MaHDN, Thuoc.MaThuoc,Thuoc.TenThuoc,DonViTinh, CTN.SoLuong, CTN.Gia, ThanhTien=(Gia*CTN.SoLuong)from ChiTietHoaDonNhap CTN, Thuoc where CTN.MaThuoc = Thuoc.MaThuoc and MaHDN like '%" + txt_MaHD.Text.Trim() + "%'");
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi();
            HienThiCT();
            DisEnl(false);
            DisEnlCT(false);
            txt_MaHD.Enabled = false;
            btnChiPhi.Enabled = false;
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaNCC.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaNCC"].Value);
                txtMaNVNhap.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaNVNhap"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["NgayNhap"].Value);
                txt_MaHD.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaHoaDon"].Value);
                HienThiCT();
                btnChiPhi.Enabled = true;
                btnHuy.Enabled = true;
            }
            else if (fluu != 0 && fluu != -1)
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaHoaDon"].Value);
                txtMaNCC.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaNCC"].Value);
                txtMaNVNhap.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaNVNhap"].Value);
                dtNgayNhap.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["NgayNhap"].Value);
                txt_MaHD.Text = Convert.ToString(dgvHoaDonNhap.CurrentRow.Cells["MaHoaDon"].Value);
                HienThiCT();
                btnChiPhi.Enabled = true;
                btnHuy.Enabled = true;
            }


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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BUS.DeleteData(txtMaHD.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaNVNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nhân viên nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtNgayNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HDN.MaHoaDon = txtMaHD.Text;
            HDN.MaNCC = txtMaHD.Text;
            HDN.MaNVNhap = txtMaNVNhap.Text;
            HDN.NgayNhap = dtNgayNhap.Value;
            if (txtMaHD.Text != "" && txtMaNCC.Text != "" && txtMaNVNhap.Text != "" && dtNgayNhap.Text != "" && fluu == 0)
            {
                try
                {
                    BUS.InsertData(HDN);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonNhap_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaHD.Text != "" && txtMaNCC.Text != "" && txtMaNVNhap.Text != "" && dtNgayNhap.Text != "" && fluu == 0 && fluu != 0)
            {
                try
                {
                    BUS.UpdateData(HDN);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonNhap_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                DisEnlCT(false);
                btnChiPhi.Enabled = false;
                fluu = 1;

            }
            else
                return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Phiếu")
            {
                dgvHoaDonNhap.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Nhà Cung Cấp")
            {
                dgvHoaDonNhap.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where MaKH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHoaDonNhap.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where MaNVXuat Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày Nhập(năm-tháng-ngày)")
            {
                dgvHoaDonNhap.DataSource = BUS.TimKiemHDN("select * from HoaDonNhap where NgayXuat like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void dgvChiTietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaThuoc.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["MaThuoc"].Value);
            cbDonViTinh.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["DonViTinh"].Value);
            txtSoLuong.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["SoLuong"].Value);
            txtGia.Text = Convert.ToString(dgvChiTietHDN.CurrentRow.Cells["Gia"].Value);
        }

        private void dgvHoaDonNhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDonNhap.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietHDN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDN.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = -1;
            DisEnlCT(true);
            txtMaNCC.Enabled = false;
            txtMaNVNhap.Enabled = false;
            dtNgayNhap.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnLamMoi.Enabled = false;
            btnHuy.Enabled = true;

            txtMaHD.Enabled = false;
            txt_MaHD.Enabled = false;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {

            fluu = 2;
            DisEnl(true);
            DisEnlCT(true);
            btnLamMoi.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHD.Enabled = false;
            txt_MaHD.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    BUS.DeleteDataCT(txt_MaHD.Text, txtMaThuoc.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnlCT(false);
                    HienThi();
                    HienThiCT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txt_MaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thuốc! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbDonViTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá thuốc! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            long _gia;
            long.TryParse(txtGia.Text, out _gia);

            CT.MaHDN = txt_MaHD.Text;
            CT.MaThuoc = txtMaThuoc.Text;
            CT.DonViTinh = cbDonViTinh.Text;
            CT.SoLuong = _soLuong;
            CT.Gia = _gia;


            if (txt_MaHD.Text != "" && txtMaThuoc.Text != "" && cbDonViTinh.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "" && fluu == -1)
            {
                try
                {

                    BUS.InsertDataCT(CT);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmHoaDonNhap_Load(sender, e);
                    clearData();
                    DisEnlCT(false);
                    fluu = 2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txt_MaHD.Text != "" && txtMaThuoc.Text != "" && cbDonViTinh.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "" && fluu != -1 && fluu != 0)
            {
                try
                {
                    BUS.UpdateDataCT(CT);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmHoaDonNhap_Load(sender, e);
                    clearData();
                    DisEnlCT(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnDSCT_Click(object sender, EventArgs e)
        {
            dgvChiTietHDN.DataSource = BUS.GetCTHDN("select * from ChiTietHoaDonNhap");
            btnHuy.Enabled = true;
        }

        private void btnChiPhi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
