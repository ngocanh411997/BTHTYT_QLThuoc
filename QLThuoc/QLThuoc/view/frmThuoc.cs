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
    public partial class frmThuoc : Form
    {
        Thuoc T = new Thuoc();
        ThuocBUS Bus = new ThuocBUS();
        private int fluu = 1;
        //private object cboTenThuoc;
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void dgvThuoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThuoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaThuoc.Enabled = e;
            txtTenThuoc.Enabled = e;
            cbMaLoaiThuoc.Enabled = e;
            cbMaDVSX.Enabled = e;
            txtCongDung.Enabled = e;
            dateHSD.Enabled = e;
            txtNuocSX.Enabled = e;



        }
        public void Clear()
        {
            txtMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            cbMaLoaiThuoc.Text = "";
            cbMaDVSX.Text = "";
            txtCongDung.Text = "";
            dateHSD.Text = "";
            txtNuocSX.Text = "";

        }
        private void HienThi()
        {
            dgvThuoc.DataSource = Bus.GetData();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenThuoc.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["TenThuoc"].Value);
                cbMaLoaiThuoc.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaLoaiThuoc"].Value);
                cbMaDVSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaDVSX"].Value);
                txtCongDung.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["CongDung"].Value);
                cbMaDVSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaDVSX"].Value);
                dateHSD.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["HSD"].Value);
                txtNuocSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["NuocSX"].Value);

            }
            else
            {
                txtMaThuoc.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaThuoc"].Value);
                txtTenThuoc.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["TenThuoc"].Value);
                cbMaLoaiThuoc.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaLoaiThuoc"].Value);
                cbMaDVSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaDVSX"].Value);
                txtCongDung.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["CongDung"].Value);
                cbMaDVSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["MaDVSX"].Value);
                dateHSD.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["HSD"].Value);
                txtNuocSX.Text = Convert.ToString(dgvThuoc.CurrentRow.Cells["NuocSX"].Value);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            fluu = 0;
            txtMaThuoc.Text = Bus.TangMaT();
            DisEnl(true);
            txtMaThuoc.Enabled = false;
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

            if (txtMaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã thuốc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thuốc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaLoaiThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã loại thuốc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbMaDVSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã ĐVSX!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtCongDung.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập công dụng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dateHSD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hạn sử dụng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNuocSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nơi sản xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
            T.MaThuoc = txtMaThuoc.Text;
            T.TenThuoc = txtTenThuoc.Text;
            T.MaLoaiThuoc = cbMaLoaiThuoc.Text;
            T.MaDVSX = cbMaDVSX.Text;
            T.CongDung = txtCongDung.Text;
            T.HSD = dateHSD.Text;
            
            T.NuocSX = txtNuocSX.Text;
            if (txtMaThuoc.Text != "" && txtTenThuoc.Text != "" && cbMaLoaiThuoc.Text != "" && cbMaDVSX.Text != "" && txtCongDung.Text != "" && dateHSD.Text != "" && txtNuocSX.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(T);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmThuoc_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaThuoc.Text != "" && txtTenThuoc.Text != "" && cbMaLoaiThuoc.Text != "" && cbMaDVSX.Text != "" && txtCongDung.Text != "" && dateHSD.Text != "" && txtNuocSX.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(T);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmThuoc_Load(sender, e);
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
                    Bus.DeleteData(txtMaThuoc.Text);
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
            if (cbTimKiem.Text == "Mã Thuốc")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where MaThuoc like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Thuốc")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where TenThuoc like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Mã Loại Thuốc")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where MaLoaiThuoc Like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Mã ĐVSX")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where MaDVSX like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Công Dụng")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where CongDung like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "HSD")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where HSD like '%" + txtTimKiem.Text.Trim() + "%'");
            }           
            if (cbTimKiem.Text == "Nước SX")
            {
                dgvThuoc.DataSource = Bus.TimKiemThuoc("select * from Thuoc where NuocSX like N'%" + txtTimKiem.Text.Trim() + "%'");
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
