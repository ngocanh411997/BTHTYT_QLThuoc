using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLThuoc.Tool;

namespace QLThuoc.view
{
    public partial class frmSQL_conn : Form
    {
        public frmSQL_conn()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string connect = "";
            bool Check = false;
            btnConn.Enabled = false;
            if (cbAuthecation.Text == "Windows Authencation")
            {

                connect = txtServerName.Text + ";Initial Catalog=" + txtDataBaseName.Text + ";Integrated Security=True;Connection Timeout=8";
            }
            else if (cbAuthecation.Text == "SQL Server Authencation")
            {
                connect = txtServerName.Text + ";Initial Catalog=" + txtDataBaseName.Text + ";Persist Security Info=True;User ID=" + txtUser.Text + ";Password=" + txtPass.Text + ";Connection Timeout=8";
            }

            SqlConnection conn = new SqlConnection("Data Source= " + connect);

            try
            {
                conn.Open();
                System.IO.StreamWriter ghi = new System.IO.StreamWriter("DataBase\\String.txt");
                //ghi.Write("SS" + Encode.StringToBase64(connect));
                ghi.Write(Encode.StringToBase64(connect));
                ghi.Close();
                ghi.Dispose();
                Check = true;
            }
            catch (Exception t)
            {

                Check = false;
                MessageBox.Show("Vui lòng kiểm tra lại kết nối\nError: " + t.Message, "Lỗi kết nối đến CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConn.Enabled = true;
            }

            conn.Close();
            if (Check == true)
            {
                MessageBox.Show("Connection successful!");
                this.Close();
            }
        }

        private void cbAuthecation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthecation.Text == "SQL Server Authencation")
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
                txtUser.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chưa kết nối với cơ sở dữ liệu bạn chắc chắn thoát ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
