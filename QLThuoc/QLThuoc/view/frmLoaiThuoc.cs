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
    public partial class frmLoaiThuoc : Form
    {
        LoaiThuoc LT = new LoaiThuoc();
        LoaiThuocBUS Bus = new LoaiThuocBUS();
        private int fluu = 1;
       // private object cboTenLoaiThuoc;
        public frmLoaiThuoc()
        {
            InitializeComponent();
        }

        private void frmLoaiThuoc_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaLoaiThuoc.Text = Bus.TangMa();
            DisEnl(true);
            txtMaLoaiThuoc.Enabled = false;
        }

        private void dgvLoaiThuoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLoaiThuoc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
           
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaLoaiThuoc.Enabled = e;
            txtTenLoaiThuoc.Enabled = e;
            txtGhiChu.Enabled = e;




        }
        public void Clear()
        {
            txtMaLoaiThuoc.Text = "";
            txtTenLoaiThuoc.Text = "";
            txtGhiChu.Text = "";


        }
        private void HienThi()
        {
            dgvLoaiThuoc.DataSource = Bus.GetData();
        }

        private void dgvLoaiThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenLoaiThuoc.Text = Convert.ToString(dgvLoaiThuoc.CurrentRow.Cells["TenLoaiThuoc"].Value);
                txtGhiChu.Text = Convert.ToString(dgvLoaiThuoc.CurrentRow.Cells["GhiChu"].Value);


            }
            else
            {
                txtMaLoaiThuoc.Text = Convert.ToString(dgvLoaiThuoc.CurrentRow.Cells["MaLoaiThuoc"].Value);
                txtTenLoaiThuoc.Text = Convert.ToString(dgvLoaiThuoc.CurrentRow.Cells["TenLoaiThuoc"].Value);
                txtGhiChu.Text = Convert.ToString(dgvLoaiThuoc.CurrentRow.Cells["GhiChu"].Value);


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

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaLoaiThuoc.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã loại thuốc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenLoaiThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại thuốc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ghi chú!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            LT.MaLoaiThuoc = txtMaLoaiThuoc.Text;
            LT.TenLoaiThuoc = txtTenLoaiThuoc.Text;
            LT.GhiChu = txtGhiChu.Text;


            if (txtMaLoaiThuoc.Text != "" && txtTenLoaiThuoc.Text != "" && txtGhiChu.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(LT);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmLoaiThuoc_Load(sender, e);
                    Clear();
                    DisEnl(false);
                    fluu = 1;
                }
                catch
                {

                }
            }
            else if (txtMaLoaiThuoc.Text != "" && txtTenLoaiThuoc.Text != "" && txtGhiChu.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(LT);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmLoaiThuoc_Load(sender, e);
                    Clear();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaLoaiThuoc.Text);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Loại Thuốc")
            {
                dgvLoaiThuoc.DataSource = Bus.TimKiemLoaiThuoc("select * from LoaiThuoc where MaLoaiThuoc like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Loại Thuốc")
            {
                dgvLoaiThuoc.DataSource = Bus.TimKiemLoaiThuoc("select * from LoaiThuoc where TenLoaiThuoc like N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ghi Chú")
            {
                dgvLoaiThuoc.DataSource = Bus.TimKiemLoaiThuoc("select * from LoaiThuoc where GhiChu Like N'%" + txtTimKiem.Text.Trim() + "%'");
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HienThi();
        }

    }
}
