using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Entity;
using QLThuoc.models;


namespace QLThuoc.view
{
    public partial class frmChiPhi : Form
    {
        HoaDonNhap HDN = new HoaDonNhap();
        HoaDonNhapBUS BUS = new HoaDonNhapBUS();
        public frmChiPhi()
        {
            InitializeComponent();
        }
        string ma = "";
        public frmChiPhi(string text):this()
        {
            ma = text;
        }
        private void HienThi()
        {
            txtMaHDN.Text = ma;
            txtMaHDN.Enabled = false;
            dgvChiPhi.DataSource = BUS.TinhChiPhi("SELECT NhaCungCap.MaNCC,TenNCC,ChiTietHoaDonNhap.MaHDN,SUM(ThanhTien) as TongTien FROM dbo.HoaDonNhap INNER JOIN dbo.ChiTietHoaDonNhap ON ChiTietHoaDonNhap.MaHDN = HoaDonNhap.MaHoaDon INNER JOIN NhaCungCap on NhaCungCap.MaNCC = HoaDonNhap.MaNCC where MaHDN ='" + txtMaHDN.Text + "'group by NhaCungCap.MaNCC, TenNCC, ChiTietHoaDonNhap.MaHDN");
        }
        private void frmChiPhi_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HDN.MaHoaDon = txtMaHDN.Text;
            BUS.Update_ChiPhi(HDN);
            MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
