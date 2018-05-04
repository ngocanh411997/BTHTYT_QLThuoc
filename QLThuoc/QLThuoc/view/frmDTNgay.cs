using QLThuoc.BUS;
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
    public partial class frmDTNgay : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public frmDTNgay()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvDTNgay.DataSource = Bus.DTNgay();
            dgvDTNgay.AutoResizeColumns();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDTNgay.DataSource = Bus.TimKiemHDX("SELECT NgayXuat, SUM(ThanhTien) AS DTNgay FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX WHERE NgayXuat like '%"+txtTimKiem.Text+"%' GROUP BY NgayXuat");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
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

        private void frmDTNgay_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvDTNgay_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDTNgay.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
