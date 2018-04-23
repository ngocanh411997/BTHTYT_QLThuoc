﻿using System;
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

        private void btnHoaDonTT_Click(object sender, EventArgs e)
        {
            frmHoaDonDaThanhToan HDTT = new frmHoaDonDaThanhToan();
            HDTT.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien NhanVien = new frmNhanVien();
            NhanVien.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void btnHDXuat_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat HDX = new frmHoaDonXuat();
            HDX.ShowDialog();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc Thuoc = new frmThuoc();
            Thuoc.ShowDialog();
        }

        private void btnLoaiThuoc_Click(object sender, EventArgs e)
        {
            frmLoaiThuoc LoaiThuoc = new frmLoaiThuoc();
            LoaiThuoc.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCC NCC = new frmNhaCC();
            NCC.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang KH = new frmKhachHang();
            KH.ShowDialog();
        }

        private void btnHDNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap HDN = new frmHoaDonNhap();
            HDN.ShowDialog();
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            frmCoSo CS = new frmCoSo();
            CS.ShowDialog();
        }
    }
}
