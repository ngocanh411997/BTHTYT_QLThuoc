using QLThuoc.BUS;
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
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();
        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void ShowCS()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListCS();
            cbMaCS.DataSource = dt;
            cbMaCS.DisplayMember = "TenCS";
            cbMaCS.ValueMember = "MaCS";

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThongKe.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMaNV.Enabled = e;
            txtSDT.Enabled = e;
            txtTenNV.Enabled = e;
            radNam.Enabled = e;
            radNu.Enabled = e;
            cbMaCS.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTenNV.Text = "";
            cbMaCS.Text = "";

        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
            ShowCS();
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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                cbMaCS.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenCS"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);                
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                cbMaCS.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenCS"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaCS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cơ sở của nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radNam.Checked == false && radNu.Checked==false)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj.MaNV = txtMaNV.Text;
            obj.TenNV = txtTenNV.Text;
            obj.MaCS = cbMaCS.SelectedValue.ToString();
            obj.DiaChi = txtDiaChi.Text;   
            obj.SDT = txtSDT.Text;
            obj.NgaySinh = dtNgaySinh.Value;
            string gt;
            if (radNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            obj.GioiTinh = gt;
            if (txtMaNV.Text != "" && txtTenNV.Text != ""&& txtDiaChi.Text !="" && txtSDT.Text !="" && cbMaCS.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && cbMaCS.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
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
                    Bus.DeleteData(txtMaNV.Text);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã nhân viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where MaNV like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên nhân viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where TenNV like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày sinh")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where NgaySinh Like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where SDT like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Giới tính")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where GioiTinh like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Địa chỉ")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where DiaChi like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Cơ sở")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where MaCS like '%" + txtTimKiem.Text + "%'");
            }
        }

        
    }
}
