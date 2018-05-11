namespace QLThuoc.view
{
    partial class frm_ChiTietHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChiTietHoaDonNhap));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this._STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTenThuoc = new System.Windows.Forms.ComboBox();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDSCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChiPhi = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dgvChiTietHDN);
            this.groupBox7.Location = new System.Drawing.Point(12, 226);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(700, 315);
            this.groupBox7.TabIndex = 63;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Phiếu Yêu Cầu";
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._STT,
            this.MaHDN,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dgvChiTietHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHDN.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.RowHeadersVisible = false;
            this.dgvChiTietHDN.Size = new System.Drawing.Size(694, 296);
            this.dgvChiTietHDN.TabIndex = 0;
            this.dgvChiTietHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHDN_CellClick);
            this.dgvChiTietHDN.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChiTietHDN_RowPrePaint);
            // 
            // _STT
            // 
            this._STT.HeaderText = "STT";
            this._STT.Name = "_STT";
            this._STT.Width = 50;
            // 
            // MaHDN
            // 
            this.MaHDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHDN.DataPropertyName = "MaHDN";
            this.MaHDN.HeaderText = "Mã HĐ";
            this.MaHDN.Name = "MaHDN";
            this.MaHDN.Width = 80;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.Name = "TenThuoc";
            // 
            // DonViTinh
            // 
            this.DonViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbTenThuoc);
            this.groupBox1.Controls.Add(this.cbDonViTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(263, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 169);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Chi Tiết Phiếu Yêu Cầu";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(98, 133);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(174, 20);
            this.txtGia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giá";
            // 
            // cbTenThuoc
            // 
            this.cbTenThuoc.FormattingEnabled = true;
            this.cbTenThuoc.Location = new System.Drawing.Point(98, 58);
            this.cbTenThuoc.Name = "cbTenThuoc";
            this.cbTenThuoc.Size = new System.Drawing.Size(174, 21);
            this.cbTenThuoc.TabIndex = 9;
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Items.AddRange(new object[] {
            "Viên",
            "Vỉ",
            "Túi",
            "Gói"});
            this.cbDonViTinh.Location = new System.Drawing.Point(98, 82);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(174, 21);
            this.cbDonViTinh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(98, 109);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(98, 32);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(174, 20);
            this.txt_MaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 39);
            this.label12.TabIndex = 67;
            this.label12.Text = "Chi tiết hóa đơn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDSCT);
            this.groupBox5.Controls.Add(this.btnLuuCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Location = new System.Drawing.Point(3, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 169);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnDSCT
            // 
            this.btnDSCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSCT.Image = ((System.Drawing.Image)(resources.GetObject("btnDSCT.Image")));
            this.btnDSCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSCT.Location = new System.Drawing.Point(179, 103);
            this.btnDSCT.Name = "btnDSCT";
            this.btnDSCT.Size = new System.Drawing.Size(51, 53);
            this.btnDSCT.TabIndex = 18;
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
            this.btnLuuCT.Location = new System.Drawing.Point(100, 103);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(51, 53);
            this.btnLuuCT.TabIndex = 17;
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
            this.btnXoaCT.Location = new System.Drawing.Point(179, 26);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(51, 53);
            this.btnXoaCT.TabIndex = 16;
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
            this.btnSuaCT.Location = new System.Drawing.Point(100, 26);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(51, 53);
            this.btnSuaCT.TabIndex = 15;
            this.btnSuaCT.Text = "Sửa CT";
            this.btnSuaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(22, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(51, 53);
            this.btnHuy.TabIndex = 64;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemCT.Location = new System.Drawing.Point(22, 26);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(51, 53);
            this.btnThemCT.TabIndex = 14;
            this.btnThemCT.Text = "Thêm CT";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(646, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChiPhi
            // 
            this.btnChiPhi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChiPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnChiPhi.Image")));
            this.btnChiPhi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChiPhi.Location = new System.Drawing.Point(568, 154);
            this.btnChiPhi.Name = "btnChiPhi";
            this.btnChiPhi.Size = new System.Drawing.Size(51, 53);
            this.btnChiPhi.TabIndex = 69;
            this.btnChiPhi.Text = "Chi Phí";
            this.btnChiPhi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiPhi.UseVisualStyleBackColor = false;
            this.btnChiPhi.Click += new System.EventHandler(this.btnChiPhi_Click);
            // 
            // frm_ChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 492);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiPhi);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ChiTietHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.frm_ChiTietHoaDonNhap_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvChiTietHDN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbTenThuoc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDSCT;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}