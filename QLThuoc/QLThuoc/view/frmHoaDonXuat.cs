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
            txtMaHD.Enabled = e;
            txtMaKH.Enabled = e;
            txtMaNVXuat.Enabled = e;
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


            if (txtMaHD.Text != "" && txtMaKH.Text != "" && txtMaNVXuat.Text != "" && dtNgayXuat.Text != "" && fluu == 0)
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
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaHoaDon like '%" + txtTimKiem.Text.Trim() + "%'and TRANGTHAI=N'Chưa thanh toán'");
            }
            if (cbTimKiem.Text == "Khách Hàng")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaKH like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán'");
            }
            if (cbTimKiem.Text == "Nhân Viên")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where MaNVXuat Like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán'");
            }
            if (cbTimKiem.Text == "Ngày Nhập(năm-tháng-ngày)")
            {
                dgvHoaDonXuat.DataSource = Bus.TimKiemHDX("select * from HoaDonXuat where NgayXuat like '%" + txtTimKiem.Text.Trim() + "%' and TRANGTHAI=N'Chưa thanh toán'");
            }
        }
        /// <summary>
        /// Chi tiết hóa đơn xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = -1;
            
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
            
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 2;
            DisEnl(true);
            
            btnLamMoi.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHD.Enabled = false;
           
        }

        private void dgvHoaDonXuat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtMaKH.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaKH"].Value);
                txtMaNVXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaNVXuat"].Value);
                dtNgayXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["NgayXuat"].Value);
            }
            else if (fluu != 0 && fluu != -1)
            {
                txtMaHD.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaHoaDon"].Value);
                txtMaKH.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaKH"].Value);
                txtMaNVXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["MaNVXuat"].Value);
                dtNgayXuat.Text = Convert.ToString(dgvHoaDonXuat.CurrentRow.Cells["NgayXuat"].Value);
              
            }
        }

        private void dgvHoaDonXuat_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHoaDonXuat.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã HĐ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frmChiTietHoaDonXuat CT = new frmChiTietHoaDonXuat(txtMaHD.Text);
                CT.ShowDialog();
                this.Show();
            } 
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
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

        private void btnThoat_Click_1(object sender, EventArgs e)
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
