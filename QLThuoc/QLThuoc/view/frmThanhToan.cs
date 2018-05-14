using QLThuoc.BUS;
using QLThuoc.Entity;
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
    public partial class frmThanhToan : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        HoaDonXuatEntity obj = new HoaDonXuatEntity();
        public frmThanhToan()
        {
            InitializeComponent();
        }

        string ma;
        public frmThanhToan(string text):this()
        {
            ma = text;

        }

        private void HienThi()
        {
            txtMaHDX.Text = ma;
            txtMaHDX.Enabled = false;
            dgvThanhToan.DataSource = Bus.ThanhToan("SELECT HoaDonXuat.MaKH,TenKH,MaHDX, SUM(ThanhTien) AS TongTien FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon INNER JOIN dbo.KhachHang ON KhachHang.MaKH = HoaDonXuat.MaKH WHERE MaHDX = '"+txtMaHDX.Text+"' GROUP BY HoaDonXuat.MaKH, TenKH, MaHDX");
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

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            obj.MaHoaDon = txtMaHDX.Text;
            Bus.UpdateDataTT(obj);
            MessageBox.Show("Xuất hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            //frmInHoaDonXuat InHD = new frmInHoaDonXuat(txtMaHDX.Text);
            //InHD.ShowDialog();
        }
    }
}
