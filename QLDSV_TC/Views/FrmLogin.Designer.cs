namespace QLDSV_TC
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pncLogin = new DevExpress.XtraEditors.PanelControl();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.chkIsStudent = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pncLogin)).BeginInit();
            this.pncLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pncLogin
            // 
            this.pncLogin.Appearance.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pncLogin.Appearance.Options.UseFont = true;
            this.pncLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pncLogin.Controls.Add(this.lblLogin);
            this.pncLogin.Controls.Add(this.lblDescription);
            this.pncLogin.Controls.Add(this.panelControl4);
            this.pncLogin.Controls.Add(this.panelControl5);
            this.pncLogin.Location = new System.Drawing.Point(0, 0);
            this.pncLogin.Name = "pncLogin";
            this.pncLogin.Size = new System.Drawing.Size(704, 500);
            this.pncLogin.TabIndex = 10;
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("SF Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogin.Appearance.Options.UseFont = true;
            this.lblLogin.Appearance.Options.UseForeColor = true;
            this.lblLogin.Appearance.Options.UseTextOptions = true;
            this.lblLogin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(704, 48);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "ĐĂNG NHẬP";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDescription.Location = new System.Drawing.Point(108, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(514, 24);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Hệ thống quản lý điểm sinh viên hệ tín chỉ";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl4.Appearance.Options.UseFont = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.btnExit);
            this.panelControl4.Controls.Add(this.btnLogin);
            this.panelControl4.Location = new System.Drawing.Point(44, 367);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(635, 65);
            this.panelControl4.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(380, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(68, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelControl5
            // 
            this.panelControl5.Appearance.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl5.Appearance.Options.UseFont = true;
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.chkIsStudent);
            this.panelControl5.Controls.Add(this.txtPassword);
            this.panelControl5.Controls.Add(this.txtUsername);
            this.panelControl5.Controls.Add(this.lblPassword);
            this.panelControl5.Controls.Add(this.lblUsername);
            this.panelControl5.Controls.Add(this.cbKhoa);
            this.panelControl5.Controls.Add(this.lblKhoa);
            this.panelControl5.Location = new System.Drawing.Point(44, 91);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(635, 260);
            this.panelControl5.TabIndex = 7;
            // 
            // chkIsStudent
            // 
            this.chkIsStudent.AutoSize = true;
            this.chkIsStudent.Location = new System.Drawing.Point(68, 212);
            this.chkIsStudent.Name = "chkIsStudent";
            this.chkIsStudent.Size = new System.Drawing.Size(163, 38);
            this.chkIsStudent.TabIndex = 10;
            this.chkIsStudent.Text = "Sinh Viên";
            this.chkIsStudent.UseVisualStyleBackColor = true;
            this.chkIsStudent.CheckStateChanged += new System.EventHandler(this.chkIsStudent_CheckStateChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(459, 35);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(149, 82);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(459, 35);
            this.txtUsername.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(9, 157);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(118, 24);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(9, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(130, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Tài khoản:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.ItemHeight = 28;
            this.cbKhoa.Location = new System.Drawing.Point(149, 9);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(459, 36);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(9, 15);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(142, 24);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa/Phòng:";
            // 
            // FrmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(704, 471);
            this.Controls.Add(this.pncLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmLogin.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pncLogin)).EndInit();
            this.pncLogin.ResumeLayout(false);
            this.pncLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pncLogin;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.CheckBox chkIsStudent;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private DevExpress.XtraEditors.LabelControl lblLogin;
    }
}

