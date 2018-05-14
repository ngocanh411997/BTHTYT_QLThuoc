using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Helper;

namespace QLThuoc.view
{
    public partial class frmTongChiPhi : Form
    {
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        public frmTongChiPhi()
        {
            InitializeComponent();
        }
        public void HienThiNgay()
        {
            dgvTongChiPhi.DataSource = BUS.ChiPhiNgay();
            dgvTongChiPhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            HienThiNgay();
        }
        public void HienThiThang()
        {
            dgvTongChiPhi.DataSource = BUS.ChiPhiThang();
            dgvTongChiPhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            HienThiThang();
        }
        public void HienThiNam()
        {
            dgvTongChiPhi.DataSource = BUS.ChiPhiNam();
            dgvTongChiPhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnNam_Click(object sender, EventArgs e)
        {
            HienThiNam();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThiNgay();
            //HienThiThang();
            //HienThiNam();
           
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvTongChiPhi);
        }
    }
}
