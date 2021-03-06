namespace QuanLyNhanKhau.View
{
    partial class Form_SignUp
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
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnConfirmOpenEye = new System.Windows.Forms.PictureBox();
            this.btnConfirmCloseEye = new System.Windows.Forms.PictureBox();
            this.btnCloseEye = new System.Windows.Forms.PictureBox();
            this.btnEye = new System.Windows.Forms.PictureBox();
            this.txbConfirm = new System.Windows.Forms.TextBox();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmOpenEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmCloseEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txbUser.Location = new System.Drawing.Point(76, 92);
            this.txbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(544, 23);
            this.txbUser.TabIndex = 1;
            this.txbUser.Text = "USER";
            this.txbUser.Enter += new System.EventHandler(this.txbTaiKhoan_Enter);
            this.txbUser.Leave += new System.EventHandler(this.txbUser_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "SIGN UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(79, 351);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(544, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Register";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnRegisterClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 449);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnConfirmCloseEye);
            this.panel2.Controls.Add(this.txtCCCD);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btnConfirmOpenEye);
            this.panel2.Controls.Add(this.btnCloseEye);
            this.panel2.Controls.Add(this.btnEye);
            this.panel2.Controls.Add(this.txbConfirm);
            this.panel2.Controls.Add(this.lbErrorMessage);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txbPassword);
            this.panel2.Controls.Add(this.txbUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(333, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 449);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCCCD.Location = new System.Drawing.Point(76, 273);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(544, 23);
            this.txtCCCD.TabIndex = 16;
            this.txtCCCD.Text = "CMND/CCCD";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.Location = new System.Drawing.Point(288, 413);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Return to Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnConfirmOpenEye
            // 
            this.btnConfirmOpenEye.ErrorImage = null;
            this.btnConfirmOpenEye.Image = global::QuanLyNhanKhau.Properties.Resources.view;
            this.btnConfirmOpenEye.InitialImage = null;
            this.btnConfirmOpenEye.Location = new System.Drawing.Point(596, 212);
            this.btnConfirmOpenEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmOpenEye.Name = "btnConfirmOpenEye";
            this.btnConfirmOpenEye.Size = new System.Drawing.Size(27, 25);
            this.btnConfirmOpenEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfirmOpenEye.TabIndex = 14;
            this.btnConfirmOpenEye.TabStop = false;
            this.btnConfirmOpenEye.Visible = false;
            this.btnConfirmOpenEye.Click += new System.EventHandler(this.btnConfirmOpenEye_Click);
            // 
            // btnConfirmCloseEye
            // 
            this.btnConfirmCloseEye.ErrorImage = null;
            this.btnConfirmCloseEye.Image = global::QuanLyNhanKhau.Properties.Resources.hidden;
            this.btnConfirmCloseEye.InitialImage = null;
            this.btnConfirmCloseEye.Location = new System.Drawing.Point(596, 212);
            this.btnConfirmCloseEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmCloseEye.Name = "btnConfirmCloseEye";
            this.btnConfirmCloseEye.Size = new System.Drawing.Size(27, 25);
            this.btnConfirmCloseEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfirmCloseEye.TabIndex = 13;
            this.btnConfirmCloseEye.TabStop = false;
            this.btnConfirmCloseEye.Click += new System.EventHandler(this.btnConfirmCloseEye_Click);
            // 
            // btnCloseEye
            // 
            this.btnCloseEye.ErrorImage = null;
            this.btnCloseEye.Image = global::QuanLyNhanKhau.Properties.Resources.hidden;
            this.btnCloseEye.InitialImage = null;
            this.btnCloseEye.Location = new System.Drawing.Point(596, 145);
            this.btnCloseEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseEye.Name = "btnCloseEye";
            this.btnCloseEye.Size = new System.Drawing.Size(27, 25);
            this.btnCloseEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseEye.TabIndex = 12;
            this.btnCloseEye.TabStop = false;
            this.btnCloseEye.Click += new System.EventHandler(this.btnCloseEye_Click);
            // 
            // btnEye
            // 
            this.btnEye.ErrorImage = null;
            this.btnEye.Image = global::QuanLyNhanKhau.Properties.Resources.view;
            this.btnEye.InitialImage = null;
            this.btnEye.Location = new System.Drawing.Point(596, 145);
            this.btnEye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(27, 25);
            this.btnEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEye.TabIndex = 11;
            this.btnEye.TabStop = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // txbConfirm
            // 
            this.txbConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbConfirm.ForeColor = System.Drawing.Color.DarkGray;
            this.txbConfirm.Location = new System.Drawing.Point(76, 213);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.Size = new System.Drawing.Size(544, 23);
            this.txbConfirm.TabIndex = 3;
            this.txbConfirm.Text = "CONFIRM PASSWORD";
            this.txbConfirm.Enter += new System.EventHandler(this.txbConfirm_Enter);
            this.txbConfirm.Leave += new System.EventHandler(this.txbConfirm_Leave);
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMessage.Location = new System.Drawing.Point(75, 311);
            this.lbErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(134, 24);
            this.lbErrorMessage.TabIndex = 10;
            this.lbErrorMessage.Text = "Error Message";
            this.lbErrorMessage.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ErrorImage = null;
            this.btnMinimize.Image = global::QuanLyNhanKhau.Properties.Resources.minimize;
            this.btnMinimize.InitialImage = null;
            this.btnMinimize.Location = new System.Drawing.Point(651, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ErrorImage = null;
            this.btnClose.Image = global::QuanLyNhanKhau.Properties.Resources.close_black_1024x10241;
            this.btnClose.InitialImage = null;
            this.btnClose.Location = new System.Drawing.Point(680, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPassword.Location = new System.Drawing.Point(79, 147);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(407, 23);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.Text = "PASSWORD";
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(707, 449);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 59;
            this.lineShape4.X2 = 466;
            this.lineShape4.Y1 = 254;
            this.lineShape4.Y2 = 254;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 57;
            this.lineShape3.X2 = 464;
            this.lineShape3.Y1 = 199;
            this.lineShape3.Y2 = 199;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 55;
            this.lineShape2.X2 = 462;
            this.lineShape2.Y1 = 154;
            this.lineShape2.Y2 = 154;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 57;
            this.lineShape1.X2 = 464;
            this.lineShape1.Y1 = 101;
            this.lineShape1.Y2 = 101;
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_SignUp";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Đăng Nhập";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmOpenEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirmCloseEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbPassword;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.TextBox txbConfirm;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.PictureBox btnEye;
        private System.Windows.Forms.PictureBox btnCloseEye;
        private System.Windows.Forms.PictureBox btnConfirmOpenEye;
        private System.Windows.Forms.PictureBox btnConfirmCloseEye;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtCCCD;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
    }
}