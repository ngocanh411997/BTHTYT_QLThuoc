namespace QLThuoc.view
{
    partial class frmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.btnNam = new System.Windows.Forms.Button();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Chocolate;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNam.Image")));
            this.btnNam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNam.Location = new System.Drawing.Point(330, 109);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(85, 100);
            this.btnNam.TabIndex = 8;
            this.btnNam.Text = "Năm";
            this.btnNam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNam.UseVisualStyleBackColor = false;
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.Chocolate;
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnNgay.Image")));
            this.btnNgay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNgay.Location = new System.Drawing.Point(48, 109);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(85, 100);
            this.btnNgay.TabIndex = 6;
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
            this.btnThang.Location = new System.Drawing.Point(195, 109);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(85, 100);
            this.btnThang.TabIndex = 7;
            this.btnThang.Text = "Tháng";
            this.btnThang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(131, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doanh Thu";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(364, 34);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 256);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(this.btnThang);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}