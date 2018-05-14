using QLThuoc.BUS;
using QLThuoc.Helper;
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
    public partial class frmKHVIP : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public frmKHVIP()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvKHVIP.DataSource = Bus.KHVIP();
            dgvKHVIP.AutoResizeColumns();
        }

        private void frmKHVIP_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvKHVIP_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvKHVIP.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                HienThi();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvKHVIP);
        }
    }
}
