﻿namespace QLThuoc.view
{
    partial class frmQuanLyChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoaiThuoc = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnHDNhap = new System.Windows.Forms.Button();
            this.btnHDXuat = new System.Windows.Forms.Button();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHDTT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoaiThuoc);
            this.groupBox1.Controls.Add(this.btnNCC);
            this.groupBox1.Controls.Add(this.btnHDNhap);
            this.groupBox1.Controls.Add(this.btnHDXuat);
            this.groupBox1.Controls.Add(this.btnThuoc);
            this.groupBox1.Controls.Add(this.btnKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý chung";
            // 
            // btnLoaiThuoc
            // 
            this.btnLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiThuoc.Image")));
            this.btnLoaiThuoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoaiThuoc.Location = new System.Drawing.Point(176, 45);
            this.btnLoaiThuoc.Name = "btnLoaiThuoc";
            this.btnLoaiThuoc.Size = new System.Drawing.Size(85, 100);
            this.btnLoaiThuoc.TabIndex = 2;
            this.btnLoaiThuoc.Text = "Loại thuốc";
            this.btnLoaiThuoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoaiThuoc.UseVisualStyleBackColor = true;
            this.btnLoaiThuoc.Click += new System.EventHandler(this.btnLoaiThuoc_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNCC.Location = new System.Drawing.Point(327, 45);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(85, 100);
            this.btnNCC.TabIndex = 2;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnHDNhap
            // 
            this.btnHDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHDNhap.Image")));
            this.btnHDNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHDNhap.Location = new System.Drawing.Point(176, 183);
            this.btnHDNhap.Name = "btnHDNhap";
            this.btnHDNhap.Size = new System.Drawing.Size(85, 100);
            this.btnHDNhap.TabIndex = 1;
            this.btnHDNhap.Text = "Hóa đơn nhập";
            this.btnHDNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHDNhap.UseVisualStyleBackColor = true;
            this.btnHDNhap.Click += new System.EventHandler(this.btnHDNhap_Click);
            // 
            // btnHDXuat
            // 
            this.btnHDXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnHDXuat.Image")));
            this.btnHDXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHDXuat.Location = new System.Drawing.Point(327, 183);
            this.btnHDXuat.Name = "btnHDXuat";
            this.btnHDXuat.Size = new System.Drawing.Size(85, 100);
            this.btnHDXuat.TabIndex = 1;
            this.btnHDXuat.Text = "Hóa đơn xuất";
            this.btnHDXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHDXuat.UseVisualStyleBackColor = true;
            this.btnHDXuat.Click += new System.EventHandler(this.btnHDXuat_Click);
            // 
            // btnThuoc
            // 
            this.btnThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThuoc.Image")));
            this.btnThuoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThuoc.Location = new System.Drawing.Point(32, 45);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(85, 100);
            this.btnThuoc.TabIndex = 1;
            this.btnThuoc.Text = "Thuốc";
            this.btnThuoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThuoc.UseVisualStyleBackColor = true;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKhachHang.Location = new System.Drawing.Point(32, 183);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(85, 100);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoanhThu);
            this.groupBox2.Controls.Add(this.btnHDTT);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnNhanVien);
            this.groupBox2.Controls.Add(this.btnCS);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 325);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý nhân sự";
            // 
            // btnHDTT
            // 
            this.btnHDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDTT.Image = ((System.Drawing.Image)(resources.GetObject("btnHDTT.Image")));
            this.btnHDTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHDTT.Location = new System.Drawing.Point(187, 183);
            this.btnHDTT.Name = "btnHDTT";
            this.btnHDTT.Size = new System.Drawing.Size(85, 100);
            this.btnHDTT.TabIndex = 4;
            this.btnHDTT.Text = "Hóa đơn đã thanh toán";
            this.btnHDTT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHDTT.UseVisualStyleBackColor = true;
            this.btnHDTT.Click += new System.EventHandler(this.btnHDTT_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(40, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kho";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhanVien.Location = new System.Drawing.Point(40, 45);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(85, 100);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.Image = ((System.Drawing.Image)(resources.GetObject("btnCS.Image")));
            this.btnCS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCS.Location = new System.Drawing.Point(187, 45);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(85, 100);
            this.btnCS.TabIndex = 2;
            this.btnCS.Text = "Cơ sở làm việc";
            this.btnCS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(883, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 100);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hệ thống quản lý thuốc";
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.Image")));
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoanhThu.Location = new System.Drawing.Point(322, 45);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(85, 100);
            this.btnDoanhThu.TabIndex = 5;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // frmQuanLyChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyChung";
            this.Text = "frmQuanLyChung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoaiThuoc;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnHDNhap;
        private System.Windows.Forms.Button btnHDXuat;
        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHDTT;
        private System.Windows.Forms.Button btnDoanhThu;
    }
}