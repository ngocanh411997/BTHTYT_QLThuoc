namespace QLThuoc.view
{
    partial class frmSQL_conn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQL_conn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.cbAuthecation = new System.Windows.Forms.ComboBox();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnConn);
            this.panel1.Controls.Add(this.cbAuthecation);
            this.panel1.Controls.Add(this.txtDataBaseName);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(469, 304);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(165, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kết nối cơ sở dữ liệu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(415, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConn.Location = new System.Drawing.Point(106, 248);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(232, 23);
            this.btnConn.TabIndex = 17;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // cbAuthecation
            // 
            this.cbAuthecation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthecation.Items.AddRange(new object[] {
            "Windows Authencation",
            "SQL Server Authencation"});
            this.cbAuthecation.Location = new System.Drawing.Point(106, 138);
            this.cbAuthecation.Name = "cbAuthecation";
            this.cbAuthecation.Size = new System.Drawing.Size(232, 21);
            this.cbAuthecation.TabIndex = 12;
            this.cbAuthecation.SelectedIndexChanged += new System.EventHandler(this.cbAuthecation_SelectedIndexChanged);
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(106, 217);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(232, 20);
            this.txtDataBaseName.TabIndex = 16;
            this.txtDataBaseName.Text = "QLThuoc";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(140, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(198, 20);
            this.txtPass.TabIndex = 15;
            this.txtPass.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(140, 165);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 20);
            this.txtUser.TabIndex = 14;
            this.txtUser.Text = "User name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(106, 111);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(233, 20);
            this.txtServerName.TabIndex = 13;
            this.txtServerName.Text = "Server Name";
            // 
            // frmSQL_conn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(516, 331);
            this.Controls.Add(this.panel1);
            this.Name = "frmSQL_conn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSQL_conn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.ComboBox cbAuthecation;
        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServerName;
    }
}