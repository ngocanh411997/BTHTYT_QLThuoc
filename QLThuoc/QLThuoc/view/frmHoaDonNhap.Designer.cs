namespace QLThuoc.view
{
    partial class frmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.btnLamTrong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNVNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHDN = new System.Windows.Forms.DataGridView();
            this._STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNVNhap = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChiPhi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDSCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamTrong
            // 
            this.btnLamTrong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamTrong.Image = ((System.Drawing.Image)(resources.GetObject("btnLamTrong.Image")));
            this.btnLamTrong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamTrong.Location = new System.Drawing.Point(129, 82);
            this.btnLamTrong.Name = "btnLamTrong";
            this.btnLamTrong.Size = new System.Drawing.Size(51, 53);
            this.btnLamTrong.TabIndex = 18;
            this.btnLamTrong.Text = "Làm Trống";
            this.btnLamTrong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamTrong.UseVisualStyleBackColor = false;
           
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTimKiem);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(20, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 64);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Nhà Cung Cấp",
            "Nhân Viên",
            "Ngày Nhập(năm-tháng-ngày)"});
            this.cbTimKiem.Location = new System.Drawing.Point(269, 26);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cbTimKiem.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Menu;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(408, 23);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(74, 25);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(86, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(6, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 26);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
         
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgvHoaDonNhap);
            this.groupBox3.Location = new System.Drawing.Point(20, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 312);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Phiếu Yêu Cầu";
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHoaDon,
            this.MaNCC,
            this.MaNVNhap,
            this.NgayNhap});
            this.dgvHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(496, 293);
            this.dgvHoaDonNhap.TabIndex = 0;
          
           
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 35;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã HĐ";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 80;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 120;
            // 
            // MaNVNhap
            // 
            this.MaNVNhap.DataPropertyName = "MaNVNhap";
            this.MaNVNhap.HeaderText = "Mã NV Nhập";
            this.MaNVNhap.Name = "MaNVNhap";
            this.MaNVNhap.Width = 120;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dgvChiTietHDN);
            this.groupBox7.Location = new System.Drawing.Point(549, 323);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(565, 315);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Phiếu Yêu Cầu";
            // 
            // dgvChiTietHDN
            // 
            this.dgvChiTietHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._STT,
            this.MaHDN,
            this.MaThuoc,
            this.TenThuoc,
            this.DonViTinh,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dgvChiTietHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHDN.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietHDN.Name = "dgvChiTietHDN";
            this.dgvChiTietHDN.RowHeadersVisible = false;
            this.dgvChiTietHDN.Size = new System.Drawing.Size(559, 296);
            this.dgvChiTietHDN.TabIndex = 0;
            
            // 
            // _STT
            // 
            this._STT.HeaderText = "STT";
            this._STT.Name = "_STT";
            this._STT.Width = 50;
            // 
            // MaHDN
            // 
            this.MaHDN.DataPropertyName = "MaHDN";
            this.MaHDN.HeaderText = "Mã HĐ";
            this.MaHDN.Name = "MaHDN";
            this.MaHDN.Width = 50;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 50;
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
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 90;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "dd/mm/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(112, 124);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(173, 20);
            this.dtNgayNhap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày nhập";
            // 
            // txtMaNVNhap
            // 
            this.txtMaNVNhap.Location = new System.Drawing.Point(112, 90);
            this.txtMaNVNhap.Name = "txtMaNVNhap";
            this.txtMaNVNhap.Size = new System.Drawing.Size(174, 20);
            this.txtMaNVNhap.TabIndex = 6;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(112, 54);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(174, 20);
            this.txtMaNCC.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(112, 23);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(174, 20);
            this.txtMaHD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NCC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã HĐ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(663, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            
            // 
            // btnChiPhi
            // 
            this.btnChiPhi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChiPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnChiPhi.Image")));
            this.btnChiPhi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChiPhi.Location = new System.Drawing.Point(549, 252);
            this.btnChiPhi.Name = "btnChiPhi";
            this.btnChiPhi.Size = new System.Drawing.Size(51, 53);
            this.btnChiPhi.TabIndex = 60;
            this.btnChiPhi.Text = "Chi Phí";
            this.btnChiPhi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiPhi.UseVisualStyleBackColor = false;
           
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(606, 252);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(51, 53);
            this.btnHuy.TabIndex = 59;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 39);
            this.label12.TabIndex = 51;
            this.label12.Text = "Hóa đơn nhập";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(15, 82);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 53);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = false;
           
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dtNgayNhap);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtMaNVNhap);
            this.groupBox8.Controls.Add(this.txtMaNCC);
            this.groupBox8.Controls.Add(this.txtMaHD);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Location = new System.Drawing.Point(20, 77);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(302, 158);
            this.groupBox8.TabIndex = 52;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nhập Thông Tin Hóa Đơn Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaThuoc);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbDonViTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(750, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 158);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Chi Tiết Phiếu Yêu Cầu";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(102, 54);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(174, 20);
            this.txtMaThuoc.TabIndex = 12;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(102, 128);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(174, 20);
            this.txtGia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 131);
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
            this.cbDonViTinh.Location = new System.Drawing.Point(102, 77);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(174, 21);
            this.cbDonViTinh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(102, 104);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(102, 27);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(174, 20);
            this.txt_MaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HĐ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDSCT);
            this.groupBox5.Controls.Add(this.btnLuuCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Location = new System.Drawing.Point(549, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(195, 158);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnDSCT
            // 
            this.btnDSCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSCT.Image = ((System.Drawing.Image)(resources.GetObject("btnDSCT.Image")));
            this.btnDSCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSCT.Location = new System.Drawing.Point(129, 82);
            this.btnDSCT.Name = "btnDSCT";
            this.btnDSCT.Size = new System.Drawing.Size(51, 53);
            this.btnDSCT.TabIndex = 18;
            this.btnDSCT.Text = "DS CT";
            this.btnDSCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDSCT.UseVisualStyleBackColor = false;
            
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuCT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.Image")));
            this.btnLuuCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuCT.Location = new System.Drawing.Point(15, 82);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(51, 53);
            this.btnLuuCT.TabIndex = 17;
            this.btnLuuCT.Text = "Lưu CT";
            this.btnLuuCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuCT.UseVisualStyleBackColor = false;
           
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaCT.Location = new System.Drawing.Point(129, 23);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(51, 53);
            this.btnXoaCT.TabIndex = 16;
            this.btnXoaCT.Text = "Xóa CT";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaCT.UseVisualStyleBackColor = false;
          
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.Image")));
            this.btnSuaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaCT.Location = new System.Drawing.Point(72, 23);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(51, 53);
            this.btnSuaCT.TabIndex = 15;
            this.btnSuaCT.Text = "Sửa CT";
            this.btnSuaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaCT.UseVisualStyleBackColor = false;
           
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemCT.Location = new System.Drawing.Point(15, 23);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(51, 53);
            this.btnThemCT.TabIndex = 14;
            this.btnThemCT.Text = "Thêm CT";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemCT.UseVisualStyleBackColor = false;
           
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(129, 23);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(51, 53);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
           
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(72, 23);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 53);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = false;
            
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(15, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 53);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = false;
          
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLamTrong);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Location = new System.Drawing.Point(328, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 158);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiPhi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmHoaDonNhap";
            this.Text = "frmHoaDonNhap";
            
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDN)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamTrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvChiTietHDN;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNVNhap;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChiPhi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDSCT;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNVNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn _STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}