namespace QLThuoc.view
{
    partial class frmDTNam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDTNam));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDTNam = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOANHTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnKHVIP = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDTNam);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 127);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu năm";
            // 
            // dgvDTNam
            // 
            this.dgvDTNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NGAYNHAP,
            this.DOANHTHU});
            this.dgvDTNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDTNam.Location = new System.Drawing.Point(3, 16);
            this.dgvDTNam.Name = "dgvDTNam";
            this.dgvDTNam.Size = new System.Drawing.Size(282, 108);
            this.dgvDTNam.TabIndex = 1;
            this.dgvDTNam.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDTNam_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NAM";
            this.NGAYNHAP.HeaderText = "Năm";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // DOANHTHU
            // 
            this.DOANHTHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOANHTHU.DataPropertyName = "DOANHTHU";
            dataGridViewCellStyle1.Format = "0,000";
            this.DOANHTHU.DefaultCellStyle = dataGridViewCellStyle1;
            this.DOANHTHU.HeaderText = "Doanh thu";
            this.DOANHTHU.Name = "DOANHTHU";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatFile.Location = new System.Drawing.Point(72, 145);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(51, 53);
            this.btnXuatFile.TabIndex = 34;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnKHVIP
            // 
            this.btnKHVIP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKHVIP.Image = ((System.Drawing.Image)(resources.GetObject("btnKHVIP.Image")));
            this.btnKHVIP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKHVIP.Location = new System.Drawing.Point(15, 145);
            this.btnKHVIP.Name = "btnKHVIP";
            this.btnKHVIP.Size = new System.Drawing.Size(51, 53);
            this.btnKHVIP.TabIndex = 33;
            this.btnKHVIP.Text = "KH VIP";
            this.btnKHVIP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKHVIP.UseVisualStyleBackColor = false;
            this.btnKHVIP.Click += new System.EventHandler(this.btnKHVIP_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(246, 142);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDTNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 209);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnKHVIP);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDTNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năm";
            this.Load += new System.EventHandler(this.frmDTNam_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDTNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOANHTHU;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnKHVIP;
        private System.Windows.Forms.Button btnThoat;
    }
}