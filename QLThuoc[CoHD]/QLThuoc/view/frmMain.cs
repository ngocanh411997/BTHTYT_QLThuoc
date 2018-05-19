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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHuongDan HD = new frmHuongDan();
            HD.ShowDialog();
            this.Show();
        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyChung QLC = new frmQuanLyChung();
            QLC.ShowDialog();
            this.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonNhap Nhap = new frmHoaDonNhap();
            Nhap.ShowDialog();
            this.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonXuat Xuat = new frmHoaDonXuat();
            Xuat.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmTaiKhoan TK = new frmTaiKhoan();
            //TK.ShowDialog();
            //this.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngKýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaiKhoan TK = new frmTaiKhoan();
            TK.ShowDialog();
            this.Show();
        }
    }
}
