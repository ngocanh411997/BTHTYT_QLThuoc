namespace QLThuoc.view
{
    partial class frmChiTietHoaDonXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHoaDonXuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHDX = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDSCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.cbTenThuoc = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDX)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(542, 94);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(485, 94);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(51, 53);
            this.btnThanhToan.TabIndex = 44;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(66, 76);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(51, 53);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dgvChiTietHDX);
            this.groupBox7.Location = new System.Drawing.Point(12, 176);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(613, 254);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvChiTietHDX
            // 
            this.dgvChiTietHDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHDX,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dgvChiTietHDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHDX.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietHDX.Name = "dgvChiTietHDX";
            this.dgvChiTietHDX.Size = new System.Drawing.Size(607, 235);
            this.dgvChiTietHDX.TabIndex = 0;
            this.dgvChiTietHDX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHDX_CellClick);
            this.dgvChiTietHDX.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChiTietHDX_RowPrePaint);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbTenThuoc);
            this.groupBox6.Controls.Add(this.txtGia);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.cbDonViTinh);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtSoLuong);
            this.groupBox6.Controls.Add(this.txt_MaHD);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(204, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 158);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập Thông Chi Tiết Phiếu Yêu Cầu";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(83, 124);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(174, 20);
            this.txtGia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giá";
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Items.AddRange(new object[] {
            "Viên",
            "Vỉ",
            "Túi",
            "Gói"});
            this.cbDonViTinh.Location = new System.Drawing.Point(83, 73);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(174, 21);
            this.cbDonViTinh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(83, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(83, 23);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(174, 20);
            this.txt_MaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã HĐ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDSCT);
            this.groupBox5.Controls.Add(this.btnLuuCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 158);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnDSCT
            // 
            this.btnDSCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSCT.Image = ((System.Drawing.Image)(resources.GetObject("btnDSCT.Image")));
            this.btnDSCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSCT.Location = new System.Drawing.Point(123, 76);
            this.btnDSCT.Name = "btnDSCT";
            this.btnDSCT.Size = new System.Drawing.Size(51, 53);
            this.btnDSCT.TabIndex = 13;
            this.btnDSCT.Text = "DS CT";
            this.btnDSCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDSCT.UseVisualStyleBackColor = false;
            this.btnDSCT.Click += new System.EventHandler(this.btnDSCT_Click);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuCT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.Image")));
            this.btnLuuCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuCT.Location = new System.Drawing.Point(9, 76);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(51, 53);
            this.btnLuuCT.TabIndex = 3;
            this.btnLuuCT.Text = "Lưu CT";
            this.btnLuuCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuCT.UseVisualStyleBackColor = false;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaCT.Location = new System.Drawing.Point(123, 17);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(51, 53);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xóa CT";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.Image")));
            this.btnSuaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaCT.Location = new System.Drawing.Point(66, 17);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(51, 53);
            this.btnSuaCT.TabIndex = 1;
            this.btnSuaCT.Text = "Sửa CT";
            this.btnSuaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemCT.Location = new System.Drawing.Point(9, 17);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(51, 53);
            this.btnThemCT.TabIndex = 0;
            this.btnThemCT.Text = "Thêm CT";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cbTenThuoc
            // 
            this.cbTenThuoc.FormattingEnabled = true;
            this.cbTenThuoc.Items.AddRange(new object[] {
            "Viên",
            "Vỉ",
            "Túi",
            "Gói"});
            this.cbTenThuoc.Location = new System.Drawing.Point(83, 49);
            this.cbTenThuoc.Name = "cbTenThuoc";
            this.cbTenThuoc.Size = new System.Drawing.Size(174, 21);
            this.cbTenThuoc.TabIndex = 12;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaHDX
            // 
            this.MaHDX.DataPropertyName = "MaHDX";
            this.MaHDX.HeaderText = "Mã HĐ";
            this.MaHDX.Name = "MaHDX";
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 70;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle3.Format = "0,000";
            this.Gia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 80;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "0,000";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // frmChiTietHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 442);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmChiTietHoaDonXuat";
            this.Text = "frmChiTietHoaDonXuat";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonXuat_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDX)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvChiTietHDX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDSCT;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.ComboBox cbTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}