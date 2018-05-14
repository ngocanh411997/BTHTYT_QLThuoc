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
    public partial class Kho : Form
    {
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        public Kho()
        {
            InitializeComponent();
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {

            dataGridView1.DataSource = Bus.KhoThuoc();
          
        }
    }
}
