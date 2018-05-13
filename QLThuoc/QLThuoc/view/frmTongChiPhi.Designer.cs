namespace QLThuoc.view
{
    partial class frmTongChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongChiPhi));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTongChiPhi = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tổng Chi Phí";
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Chocolate;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNam.Image")));
            this.btnNam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNam.Location = new System.Drawing.Point(330, 12);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(85, 90);
            this.btnNam.TabIndex = 14;
            this.btnNam.Text = "Năm";
            this.btnNam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.Chocolate;
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnNgay.Image")));
            this.btnNgay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNgay.Location = new System.Drawing.Point(48, 12);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(85, 90);
            this.btnNgay.TabIndex = 12;
            this.btnNgay.Text = "Ngày";
            this.btnNgay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNgay.UseVisualStyleBackColor = false;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.Chocolate;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.Image = ((System.Drawing.Image)(resources.GetObject("btnThang.Image")));
            this.btnThang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThang.Location = new System.Drawing.Point(195, 12);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(85, 90);
            this.btnThang.TabIndex = 13;
            this.btnThang.Text = "Tháng";
            this.btnThang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNam);
            this.panel1.Controls.Add(this.btnThang);
            this.panel1.Controls.Add(this.btnNgay);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 112);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTongChiPhi);
            this.panel2.Location = new System.Drawing.Point(12, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 204);
            this.panel2.TabIndex = 16;
            // 
            // dgvTongChiPhi
            // 
            this.dgvTongChiPhi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTongChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongChiPhi.Location = new System.Drawing.Point(0, 0);
            this.dgvTongChiPhi.Name = "dgvTongChiPhi";
            this.dgvTongChiPhi.Size = new System.Drawing.Size(470, 204);
            this.dgvTongChiPhi.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatFile.Location = new System.Drawing.Point(374, 403);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(51, 53);
            this.btnXuatFile.TabIndex = 41;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(431, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTongChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 468);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmTongChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTongChiPhi";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvTongChiPhi;
    }
}