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
    public partial class frmNhaCC : Form
    {
        NhaCC NCC = new NhaCC();
        NhaCCBUS Bus = new NhaCCBUS();
        private int fluu = 1;
        public frmNhaCC()
        {
            InitializeComponent();
        }

        private void dgvNhaCC_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            dgvNhaCC.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
           
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
        }
        public void Clear()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
           
        }
        private void HienThi()
        {
            dgvNhaCC.DataSource = Bus.GetData();
        }

        private void frmNhaCC_Load(object sender, EventArgs e)
        {

            HienThi();
            DisEnl(false);
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtDiaChi.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["SDT"].Value);
                txtTenNCC.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["TenNCC"].Value);
            }
            else
            {
                txtMaNCC.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["MaNCC"].Value);
                txtDiaChi.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["SDT"].Value);
                txtTenNCC.Text = Convert.ToString(dgvNhaCC.CurrentRow.Cells["TenNCC"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNCC.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNCC.Enabled = false;

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
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNCC.Text == "")
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

            NCC.MaNCC = txtMaNCC.Text;
            NCC.TenNCC = txtTenNCC.Text;
            NCC.DiaChi = txtDiaChi.Text;
            NCC.SDT = txtSDT.Text;
            if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(NCC);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhaCC_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaNCC.Text != "" && txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(NCC);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhaCC_Load(sender, e);
                    Clear();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNCC.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Bus.DeleteData(txtMaNCC.Text);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
                if (cbTimKiem.Text == "Mã nhà cung cấp")
                {
                    dgvNhaCC.DataSource = Bus.TimKiemNCC("select * from NhaCungCap where MaNCC like '%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbTimKiem.Text == "Tên nhà cung cấp")
                {
                    dgvNhaCC.DataSource = Bus.TimKiemNCC("select * from NhaCungCap where TenNCC like N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbTimKiem.Text == "Địa chỉ")
                {
                    dgvNhaCC.DataSource = Bus.TimKiemNCC("select * from NhaCungCap where DiaChi Like N'%" + txtTimKiem.Text.Trim() + "%'");
                }
                if (cbTimKiem.Text == "SĐT")
                {
                    dgvNhaCC.DataSource = Bus.TimKiemNCC("select * from NhaCungCap where SDT like '%" + txtTimKiem.Text.Trim() + "%'");
                }
            }
    }
}
    

