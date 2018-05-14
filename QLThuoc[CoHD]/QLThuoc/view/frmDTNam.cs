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
    public partial class frmDTNam : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public frmDTNam()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvDTNam.DataSource = Bus.DT("SELECT YEAR(NgayXuat) AS NAM ,SUM(ThanhTien) AS DOANHTHU FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon WHERE TrangThai=N'Đã thanh toán' GROUP BY YEAR(NgayXuat)");
            dgvDTNam.AutoResizeColumns();
        }

        private void frmDTNam_Load(object sender, EventArgs e)
        {
            HienThi();
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

        private void dgvDTNam_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDTNam.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvDTNam);
        }

        private void btnKHVIP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKHVIP KHVIP = new frmKHVIP();
            KHVIP.ShowDialog();
            this.Show();
        }
    }
}
