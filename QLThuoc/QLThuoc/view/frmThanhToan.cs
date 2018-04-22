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
        public frmThanhToan(string text) : this()
        {
            ma = text;
        }

        private void HienThi()
        {
            txtMaHDX.Text = ma;
            txtMaHDX.Enabled = false;
            dgvThanhToan.DataSource = Bus.ThanhToan("SELECT A.MaKH,TenKH,A.MaHoaDon,SUM(A.ThanhTien) as TongTien FROM dbo.KhachHang, (SELECT MaHoaDon, MaThuoc, DonViTinh, Gia, SoLuong, ThanhTien= (Gia * SoLuong), MaKH FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.HoaDonXuat ON HoaDonXuat.MaHoaDon = ChiTietHoaDonXuat.MaHDX WHERE MaHoaDon='" + txtMaHDX.Text.Trim() + "') A WHERE A.MaKH = KhachHang.MaKH GROUP BY A.MaKH,TenKH,A.MaHoaDon");
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

        private void button1_Click(object sender, EventArgs e)
        {
            obj.MaHoaDon = txtMaHDX.Text;
            Bus.GetDataHoaDonTT(obj);

            MessageBox.Show("Xuất hóa đơn thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
