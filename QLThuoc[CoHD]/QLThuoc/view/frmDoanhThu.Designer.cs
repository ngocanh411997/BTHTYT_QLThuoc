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
            this.SuspendLayout();
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Chocolate;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNam.Image")));
            this.btnNam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNam.Location = new System.Drawing.Point(312, 84);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(85, 100);
            this.btnNam.TabIndex = 8;
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
            this.btnNgay.Location = new System.Drawing.Point(30, 84);
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
            this.btnThang.Location = new System.Drawing.Point(177, 84);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(85, 100);
            this.btnThang.TabIndex = 7;
            this.btnThang.Text = "Tháng";
            this.btnThang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doanh Thu";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(this.btnThang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Label label1;
    }
}