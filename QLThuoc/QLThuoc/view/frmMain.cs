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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
