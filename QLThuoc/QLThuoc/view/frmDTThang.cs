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
    public partial class frmDTThang : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public frmDTThang()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvDTThang.DataSource = Bus.DT("SELECT MONTH(NgayXuat) AS THANG, YEAR(NgayXuat) AS NAM, SUM(ThanhTien) AS DOANHTHU FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon WHERE TrangThai = N'Đã thanh toán' GROUP BY MONTH(NgayXuat), YEAR(NgayXuat)");
            dgvDTThang.AutoResizeColumns();
        }

        private void dgvDTThang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDTThang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void frmDTThang_Load(object sender, EventArgs e)
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDTThang.DataSource = Bus.TimKiemHDX("SELECT MONTH(NgayXuat) AS THANG ,YEAR(NgayXuat) AS NAM,SUM(ThanhTien) AS DOANHTHU FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon WHERE TrangThai=N'Đã thanh toán' AND MONTH(NgayXuat)='"+txtTimKiem.Text+"' GROUP BY MONTH(NgayXuat),YEAR(NgayXuat)");
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            files.ExportToExcel(dgvDTThang);
        }
    }
}
