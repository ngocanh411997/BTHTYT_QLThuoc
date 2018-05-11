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
    public partial class frmQuanLyChung : Form
    {
        public frmQuanLyChung()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien NhanVien = new frmNhanVien();
            NhanVien.ShowDialog();
            this.Show();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCoSo CoSo = new frmCoSo();
            CoSo.ShowDialog();
            this.Show();
        }

        private void btnHDXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonXuat HDX = new frmHoaDonXuat();
            HDX.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang KhachHang = new frmKhachHang();
            KhachHang.ShowDialog();
            this.Show();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThuoc Thuoc = new frmThuoc();
            Thuoc.ShowDialog();
            this.Show();
        }

        private void btnLoaiThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiThuoc LoaiThuoc = new frmLoaiThuoc();
            LoaiThuoc.ShowDialog();
            this.Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaCC NCC = new frmNhaCC();
            NCC.ShowDialog();
            this.Show();
        }

        private void btnHDNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonNhap HDN = new frmHoaDonNhap();
            HDN.ShowDialog();
            this.Show();
        }

        private void btnHDTT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonDaThanhToan HDTT = new frmHoaDonDaThanhToan();
            HDTT.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kho K = new Kho();
            K.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoanhThu DT = new frmDoanhThu();
            DT.ShowDialog();
            this.Show();
        }
    }
}
