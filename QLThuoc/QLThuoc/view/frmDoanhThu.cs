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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDTNgay DTNgay = new frmDTNgay();
            DTNgay.ShowDialog();
            this.Show();
        }
        private void btnThang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDTThang DTThang = new frmDTThang();
            DTThang.ShowDialog();
            this.Show();
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDTNam DTN = new frmDTNam();
            DTN.ShowDialog();
            this.Show();
        }
    }
}
