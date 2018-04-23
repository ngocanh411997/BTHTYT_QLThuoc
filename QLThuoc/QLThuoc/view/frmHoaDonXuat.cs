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
    public partial class frmHoaDonXuat : Form
    {
        HoaDonXuatEntity obj = new HoaDonXuatEntity();
        ChiTietHoaDonXuatEntity CT = new ChiTietHoaDonXuatEntity();
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        private int fluu = 1;
        public frmHoaDonXuat()
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
            dtNgayXuat.Enabled = e;
            txtGia.Enabled = e;
            txtMaHD.Enabled = e;
            txtMaKH.Enabled = e;
            txtMaNVXuat.Enabled = e;          
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
            txtMaKH.Text = "";          
            txtMaNVXuat.Text = "";
            dtNgayXuat.Text = "";

        }
        private void HienThi()
        {
            dgvHoaDonXuat.DataSource = Bus.GetData();
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

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            DisEnlCT(false);
            txt_MaHD.Enabled = false;
            btnThanhToan.Enabled = false;
            
        }

        private void dgvHoaDonXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaKH.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaKH"].Value);
                txtMaNVXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaNVXuat"].Value);
                dtNgayXuat.Text= Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["NgayXuat"].Value);
                txt_MaHD.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaHoaDon"].Value);
            }
            else if(fluu !=0 && fluu !=-1)
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaHoaDon"].Value);
                txtMaKH.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaKH"].Value);
                txtMaNVXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaNVXuat"].Value);
                dtNgayXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["NgayXuat"].Value);
                txt_MaHD.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaHoaDon"].Value);
            }
        }

        private void dgvHoaDonXuat_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDonXuat.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaHD.Text = Bus.TangMa();
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
                    Bus.DeleteData(txtMaHD.Text);
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
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaNVXuat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nhân viên xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtNgayXuat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj.MaHoaDon = txtMaHD.Text;
            obj.MaKH = txtMaKH.Text;
            obj.MaNVXuat = txtMaNVXuat.Text;
            obj.NgayXuat = dtNgayXuat.Value;
          
            
            if (txtMaHD.Text != "" && txtMaKH.Text != "" && txtMaNVXuat.Text != "" && dtNgayXuat.Text != ""  && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonXuat_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaHD.Text != "" && txtMaKH.Text != "" && txtMaNVXuat.Text != "" && dtNgayXuat.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmHoaDonXuat_Load(sender, e);
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
                btnThanhToan.Enabled = false;
                fluu = 1;

            }
            else
                return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Phiếu")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaKH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaNVXuat Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày Nhập(năm-tháng-ngày)")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where NgayXuat like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }
        /// <summary>
        /// Chi tiết hóa đơn xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void HienThiCT()
        {
            dgvChiTietHDX.DataSource = Bus.DataCTHDX("SELECT * from ChiTietHoaDonXuat WHERE MaHDX LIKE '%"+txt_MaHD.Text.Trim() +"%'");
        }


        private void btnCT_Click(object sender, EventArgs e)
        {
            HienThiCT();
            btnThanhToan.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = -1;
            DisEnlCT(true);
            txtMaKH.Enabled = false;
            txtMaNVXuat.Enabled = false;
            dtNgayXuat.Enabled = false;
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
                    Bus.DeleteDataCT(txt_MaHD.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnlCT(false);
                    HienThi();
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

            CT.MaHDX = txt_MaHD.Text;
            CT.MaThuoc = txtMaThuoc.Text;
            CT.DonViTinh = cbDonViTinh.Text;
            CT.SoLuong = _soLuong;
            CT.Gia = _gia;


            if (txt_MaHD.Text != "" && txtMaThuoc.Text != "" && cbDonViTinh.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "" && fluu == -1)
            {
                try
                {
                    Bus.InsertDataCT(CT);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmHoaDonXuat_Load(sender, e);
                    clearData();
                    DisEnlCT(false);
                    fluu = 22;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txt_MaHD.Text != "" && txtMaThuoc.Text != "" && cbDonViTinh.Text != "" && txtSoLuong.Text != "" && txtGia.Text != "" && fluu != -1)
            {
                try
                {
                    Bus.UpdateDataCT(CT);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    HienThiCT();
                    frmHoaDonXuat_Load(sender, e);
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
            HienThiCT();
            btnHuy.Enabled = true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTietHDX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDX.Rows[e.RowIndex].Cells["_STT"].Value = e.RowIndex + 1;
        }

        private void dgvChiTietHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
                txtMaThuoc.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["MaThuoc"].Value);
                cbDonViTinh.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["DonViTinh"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["SoLuong"].Value);
                txtGia.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["Gia"].Value);
         
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
