using QLThuoc.BUS;
using QLThuoc.models;
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
    public partial class frmChiTietHoaDonXuat : Form
    {
        ChiTietHoaDonXuatEntity obj = new ChiTietHoaDonXuatEntity();
        HoaDonXuatBUS Bus = new HoaDonXuatBUS();
        private int fluu = 1;
        public frmChiTietHoaDonXuat()
        {
            InitializeComponent();
        }
        string ma = "";
        public frmChiTietHoaDonXuat(string text):this()
        {
            ma = text;
        }

        public void ShowThuoc()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListThuoc();
            cbTenThuoc.DataSource = dt;
            cbTenThuoc.DisplayMember = "TenThuoc";
            cbTenThuoc.ValueMember = "MaThuoc";
        }
        public void ShowT()
        {
            DataTable dt = new DataTable();
            dt = Bus.GetListT("SELECT * FROM dbo.Thuoc WHERE TenThuoc NOT IN (SELECT TenThuoc FROM dbo.ChiTietHoaDonXuat INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc WHERE MaHDX='"+txt_MaHD.Text+"') AND TTT='0'");
            cbTenThuoc.DataSource = dt;
            cbTenThuoc.DisplayMember = "TenThuoc";
            cbTenThuoc.ValueMember = "MaThuoc";
        }
        private void DisEnl(bool e)
        {
            btnThemCT.Enabled = !e;
            btnXoaCT.Enabled = !e;
            btnSuaCT.Enabled = !e;
            btnLuuCT.Enabled = e;
            btnHuy.Enabled = e;            
            txtSoLuong.Enabled = e;
            cbTenThuoc.Enabled = e;
            cbDonViTinh.Enabled = e;
            txtGia.Enabled = e;
        }
        private void HienThi()
        {
            txt_MaHD.Text = ma;
            dgvChiTietHDX.DataSource = Bus.DataCTHDX("SELECT MaHDX,TenThuoc, DonViTinh,ChiTietHoaDonXuat.SoLuong,Gia,ThanhTien FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc WHERE MaHDX = '"+txt_MaHD.Text+"' and TrangThai=N'Chưa thanh toán'");
            txt_MaHD.Enabled = false;
            ShowThuoc();
            //ShowT();
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
            txt_MaHD.Enabled = false;
            ShowT();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txt_MaHD.Enabled = false;
            cbTenThuoc.Enabled = false;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteDataCT(txt_MaHD.Text, cbTenThuoc.SelectedValue.ToString());
                    MessageBox.Show("Xóa thành công!");
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            if (txt_MaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã HĐ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thuốc! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int _soLuong;
            int.TryParse(txtSoLuong.Text, out _soLuong);

            int _gia;
            int.TryParse(txtGia.Text, out _gia);

            obj.MaThuoc = cbTenThuoc.SelectedValue.ToString();
            obj.MaHDX = txt_MaHD.Text;
            obj.SoLuong = _soLuong;
            obj.Gia = _gia;
            obj.DonViTinh = cbDonViTinh.Text;

            if (txt_MaHD.Text != "" && txtSoLuong.Text != "" && cbDonViTinh.Text != "" && cbTenThuoc.Text != "" && txtGia.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertDataCT(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmChiTietHoaDonXuat_Load(sender, e);
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else if (txt_MaHD.Text != "" && txtSoLuong.Text != "" && cbDonViTinh.Text != "" && cbTenThuoc.Text != "" && txtGia.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateDataCT(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmChiTietHoaDonXuat_Load(sender, e);
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void frmChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnDSCT_Click(object sender, EventArgs e)
        {
            dgvChiTietHDX.DataSource = Bus.DataCTHDX("SELECT MaHDX,TenThuoc, DonViTinh,ChiTietHoaDonXuat.SoLuong,Gia,ThanhTien FROM dbo.HoaDonXuat INNER JOIN dbo.ChiTietHoaDonXuat ON ChiTietHoaDonXuat.MaHDX = HoaDonXuat.MaHoaDon INNER JOIN dbo.Thuoc ON Thuoc.MaThuoc = ChiTietHoaDonXuat.MaThuoc WHERE TrangThai=N'Chưa thanh toán'");
            DisEnl(true);
            txt_MaHD.Enabled = false;
            btnLuuCT.Enabled = false;
            ShowT();
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

        private void dgvChiTietHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(fluu ==0)
            {
                txtSoLuong.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["SoLuong"].Value);
                txtGia.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["Gia"].Value);
                cbDonViTinh.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["DonViTinh"].Value);
            }
            else
            {
                cbTenThuoc.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["TenThuoc"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["SoLuong"].Value);
                txtGia.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["Gia"].Value);
                cbDonViTinh.Text = Convert.ToString(dgvChiTietHDX.CurrentRow.Cells["DonViTinh"].Value);
            }
        
        }
           

        private void dgvChiTietHDX_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChiTietHDX.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThanhToan ThanhToan = new frmThanhToan(txt_MaHD.Text);
            ThanhToan.ShowDialog();
            
        }

    }
}
