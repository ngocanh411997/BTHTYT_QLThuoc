using System;
using QLThuoc.BUS;
using QLThuoc.models;
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
    public partial class frmCoSo : Form
    {
        CoSo CS = new CoSo();
        CoSoBUS Bus = new CoSoBUS();
        private int fluu = 1;
        private object cboTenCS;

        public frmCoSo()
        {
            InitializeComponent();
        }
        private void dgvCS_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvCS.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;

        }


        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnThongKe.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaCS.Enabled = e;
            txtTenCS.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
        }
        public void Clear()
        {
            txtMaCS.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenCS.Text = "";
        }
        private void HienThi()
        {
          dgvCS.DataSource = Bus.GetData();
        }

        private void frmCoSo_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvCS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (fluu == 0)
            {
                txtDiaChi.Text = Convert.ToString(dgvCS.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvCS.CurrentRow.Cells["SDT"].Value);
                txtTenCS.Text = Convert.ToString(dgvCS.CurrentRow.Cells["TenCS"].Value);
            }
            else
            {
                txtMaCS.Text = Convert.ToString(dgvCS.CurrentRow.Cells["MaCS"].Value);
                txtDiaChi.Text = Convert.ToString(dgvCS.CurrentRow.Cells["DiaChi"].Value);
                txtSDT.Text = Convert.ToString(dgvCS.CurrentRow.Cells["SDT"].Value);
                txtTenCS.Text = Convert.ToString(dgvCS.CurrentRow.Cells["TenCS"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaCS.Text = Bus.TangMa();
            DisEnl(true);
            txtMaCS.Enabled = false;
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
            txtMaCS.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenCS.Text == "")
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
            
            CS.MaCS = txtMaCS.Text;
            CS.TenCS = txtTenCS.Text;
            CS.DiaChi = txtDiaChi.Text;
            CS.SDT = txtSDT.Text;
            if (txtMaCS.Text != "" && txtTenCS.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != ""  && fluu == 0)
            {
                try
                {
                    Bus.InsertData(CS);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmCoSo_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaCS.Text != "" && txtTenCS.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(CS);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmCoSo_Load(sender, e);
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
                    Bus.DeleteData(txtMaCS.Text);
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

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã cơ sở")
            {
                dgvCS.DataSource = Bus.TimKiemCS("select * from CoSo where MaCS like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên cơ sở")
            {
                dgvCS.DataSource = Bus.TimKiemCS("select * from CoSo where TenCS like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Địa chỉ")
            {
                dgvCS.DataSource = Bus.TimKiemCS("select * from CoSo where DiaChi Like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvCS.DataSource = Bus.TimKiemCS("select * from CoSo where SDT like '%" + txtTimKiem.Text.Trim() + "%'");
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
