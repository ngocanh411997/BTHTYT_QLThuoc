using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Entity;

namespace QLThuoc.view
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoanBUS BUS = new TaiKhoanBUS();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            dgvTaiKhoan.DataSource = BUS.GetData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

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

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["Name"].Value);
            txtPass.Text = Convert.ToString(dgvTaiKhoan.CurrentRow.Cells["Pass"].Value);
        }

        private void dgvTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTaiKhoan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
