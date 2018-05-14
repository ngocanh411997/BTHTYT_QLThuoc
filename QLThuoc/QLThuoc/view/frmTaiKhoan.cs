using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLThuoc.BUS;
using QLThuoc.Entity;

namespace QLThuoc.view
{
    public partial class frmTaiKhoan : Form
    {
        TaiKhoan TK = new TaiKhoan();
        TaiKhoanBUS BUS = new TaiKhoanBUS();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TK.Name = txtName.Text;
            TK.Pass = txtPass.Text;
            BUS.ThemTK(TK);
            MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
