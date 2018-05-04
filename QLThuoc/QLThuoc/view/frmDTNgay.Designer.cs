namespace QLThuoc.view
{
    partial class frmDTNgay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDTNgay));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDTNgay = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doanh Thu ngày";
            // 
            // dgvDTNgay
            // 
            this.dgvDTNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayXuat,
            this.DTNgay});
            this.dgvDTNgay.Location = new System.Drawing.Point(48, 60);
            this.dgvDTNgay.Name = "dgvDTNgay";
            this.dgvDTNgay.Size = new System.Drawing.Size(283, 243);
            this.dgvDTNgay.TabIndex = 12;
            this.dgvDTNgay.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDTNgay_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày";
            this.NgayXuat.Name = "NgayXuat";
            // 
            // DTNgay
            // 
            this.DTNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTNgay.DataPropertyName = "DTNgay";
            dataGridViewCellStyle4.Format = "0,000";
            this.DTNgay.DefaultCellStyle = dataGridViewCellStyle4;
            this.DTNgay.HeaderText = "Doanh thu";
            this.DTNgay.Name = "DTNgay";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatFile.Location = new System.Drawing.Point(244, 309);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(51, 53);
            this.btnXuatFile.TabIndex = 35;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(301, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(15, 352);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 25);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(110, 324);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(114, 20);
            this.txtTimKiem.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(18, 320);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 26);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmDTNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 415);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDTNgay);
            this.Controls.Add(this.label1);
            this.Name = "frmDTNgay";
            this.Text = "frmDTNgay";
            this.Load += new System.EventHandler(this.frmDTNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDTNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTNgay;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}