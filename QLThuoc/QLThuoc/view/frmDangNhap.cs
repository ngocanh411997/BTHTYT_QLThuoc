using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLThuoc.BUS;

namespace QLThuoc.view
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        SqlDataAdapter da_User = new SqlDataAdapter();
        LoginBUS BUS = new LoginBUS();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LogIN();
        }        
            public void LogIN()
             {
            try
            {
                da_User = BUS.BUSLogin(txtID.Text, txtPass.Text);
                DataTable dt_User = new DataTable();
                da_User.Fill(dt_User);
                if (dt_User.Rows.Count > 0)
                {
                    if (dt_User.Rows[0][1].ToString() == "False")
                    {
                        var re = MessageBox.Show("Tài khoản của bạn đã bị khóa!\nVui lòng liên hệ với Administrator để mở.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (re == DialogResult.OK)
                        {
                            MessageBox.Show("Admin: 01675955489 / hangabc123456@gmail.com", "Liên hệ Admin: ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.Hide();
                        frmMain frmM = new frmMain();
                        frmM.ShowDialog();                    
                        this.Show();
                        //string ID = txtID.Text;
                        
                    }
                }

                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!\nVui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Text = "";
                    frmSQL_conn frm = new frmSQL_conn();
                    frm.ShowDialog();
                    this.Show();
                }
            }
            catch
            {
                
            }
        }
    }
}
