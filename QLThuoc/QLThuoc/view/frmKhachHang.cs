using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLThuoc.BUS;
using QLThuoc.models;
using QLThuoc.Entity;


namespace QLThuoc.view
{
    public partial class frmKhachHang : Form
    {

        KhachHang KH = new KhachHang();
        KhachHangBUS Bus = new KhachHangBUS();
        private int fluu = 1;
        private object cboTenCS;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void dgvKH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKH.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;

        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThongKe.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
        }
        public void Clear()
        {
            txtMaKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
        }
        private void HienThi()
        {
           dgvKH.DataSource = Bus.GetData();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (fluu == 0)
            {
                txtDiaChi.Text = Convert.ToString(dgvKH.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvKH.CurrentRow.Cells["SDT"].Value);
                txtTenKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["TenKH"].Value);
            }
            else
            {
                txtMaKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["MaKH"].Value);
                txtDiaChi.Text = Convert.ToString(dgvKH.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvKH.CurrentRow.Cells["SDT"].Value);
                txtTenKH.Text = Convert.ToString(dgvKH.CurrentRow.Cells["TenKH"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaKH.Text = Bus.TangMa();
            DisEnl(true);
            txtMaKH.Enabled = false;
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

        private void btnSua_Click(object sender, EventArgs e)
        {

            fluu = 1;
            DisEnl(true);
            txtMaKH.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenKH.Text == "")
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

            KH.MaKH = txtMaKH.Text;
            KH.TenKH = txtTenKH.Text;
            KH.DiaChi = txtDiaChi.Text;
            KH.SDT = txtSDT.Text;
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(KH);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmKhachHang_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(KH);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmKhachHang_Load(sender, e);
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
                    Bus.DeleteData(txtMaKH.Text);
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cbTimKiem.Text == "Mã khách hàng")
            {
                dgvKH.DataSource = Bus.TimKiemKH("select * from CoSo where MaKH like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên cơ sở")
            {
                dgvKH.DataSource = Bus.TimKiemKH("select * from CoSo where TenKH like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Địa chỉ")
            {
                dgvKH.DataSource = Bus.TimKiemKH("select * from CoSo where DiaChi Like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvKH.DataSource = Bus.TimKiemKH("select * from CoSo where SDT like '%" + txtTimKiem.Text.Trim() + "%'");
            }
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
    }
}
