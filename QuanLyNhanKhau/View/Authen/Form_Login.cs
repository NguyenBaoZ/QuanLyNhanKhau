using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyNhanKhau.View
{
    public interface ILogin
    {
        string Username { get; set; }
        string Password { get; set; }
        Presenter.Login _present { get; set; }
    }
    public partial class Form_Login : Form, ILogin
    {
        public string Username
        {
            get
            {
                return this.txbUser.Text;
            }
            set
            {
                this.txbUser.Text = value;
            }
        }
        public string Password
        {
            get
            {
                return this.txbPassword.Text;
            }
            set
            {
                this.txbPassword.Text = value;
            }
        }

        public Presenter.Login _present { get; set; }

        public Form_Login()
        {
            InitializeComponent();
            this._present = new Presenter.Login(this);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txbTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "USER")
            {
                txbUser.Text = "USERNAME";
                txbUser.ForeColor = Color.DarkGray;
            }
            else if (txbUser.Text == "USERNAME")
            {
                txbUser.Text = "";
                txbUser.ForeColor = Color.DarkGray;
            }
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "USERNAME";
                txbUser.ForeColor = Color.DarkGray;
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "PASSWORD")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.DarkGray;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "PASSWORD";
                txbPassword.ForeColor = Color.DarkGray;
                txbPassword.UseSystemPasswordChar = false;
            }
        }
        private void txbConfirm_Enter(object sender, EventArgs e)
        {
            if (txbConfirm.Text == "CONFIRM PASSWORD")
            {
                txbConfirm.Text = "";
                txbConfirm.ForeColor = Color.DarkGray;
                txbConfirm.UseSystemPasswordChar = true;
            }
        }

        private void txbConfirm_Leave(object sender, EventArgs e)
        {
            if (txbConfirm.Text == "")
            {
                txbConfirm.Text = "CONFIRM PASSWORD";
                txbConfirm.ForeColor = Color.DarkGray;
                txbConfirm.UseSystemPasswordChar = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac chan muon thoat khong ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.Username.Length < 5 && this.Password.Length < 5)
            {
                msgError("Please enter password and username with min length 5 character");
                txbPassword.Focus();
                return;
            }
            switch (_present.login())
            {
                case Model.LoginState.LOG_OUT:
                case Model.LoginState.LOG_IN_MODERATOR:
                    {
                        msgError("Incorrect username or password entered. \n Please try again.");
                    }
                    break;
                case Model.LoginState.LOG_IN_MEMBER:
                    {
                        Form_Base form = new Form_Base();
                        form.Show();
                        form.FormClosed += Logout;
                        this.Hide();
                    }
                    break;
                case Model.LoginState.LOG_IN_ADMIN:
                    {
                        Form_Admin form = new Form_Admin();
                        form.Show();
                        form.FormClosed += Logout;
                        this.Hide();
                    }
                    break;

            }
            //if (btnLogin.Text == "Login")
            //{
            //    if (txbUser.Text != "USERNAME")
            //    {
            //        if (txbPassword.Text != "PASSWORD")
            //        {
            //            if (txbUser.Text == "USER")
            //            {
            //                Form_Base form = new Form_Base();
            //                form.Show();
            //                form.FormClosed += Logout;
            //                this.Hide();
            //            }
            //            else if (txbUser.Text == "ADMIN")
            //            {
            //                Form_Admin form = new Form_Admin();
            //                form.Show();
            //                form.FormClosed += Logout;
            //                this.Hide();
            //            }
            //            /*Usermodel user = new Usermodel();
            //            var vallogin = user.LoginUser(txbUser.Text, txbPassword.Text);
            //            if (vallogin == true)
            //            {
            //                //Form_NV form = new Form_NV();
            //                form.Show();
            //                form.FormClosed += Logout;
            //                this.Hide();
            //            }
            //            else
            //            {
            //                msgError("Incorrect username or password entered. \n Please try again.");
            //                txbPassword.UseSystemPasswordChar = false;
            //                txbPassword.Text = "PASSWORD";
            //                txbUser.Focus();
            //            }*/
            //        }
            //        else
            //        {

            //        }
            //    }
            //    else
            //    {
            //        msgError("Please enter username.");
            //        txbUser.Focus();
            //    }
            //}
            //else if (btnLogin.Text == "Submit")
            //{
            //    if (txbUser.Text != "USERNAME")
            //    {
            //        if (txbPassword.Text != "PASSWORD")
            //        {
            //            if (txbConfirm.Text != "CONFIRM PASSWORD" && txbPassword.Text == txbConfirm.Text)
            //            {
            //                /*Usermodel user = new Usermodel();
            //                var vallogin = user.UpdateUser(txbUser.Text, txbPassword.Text);
            //                if (vallogin == true)
            //                {
            //                    announce("Password have been changed");
            //                }
            //                else
            //                {
            //                    announce("Tai khoan khong ton tai");
            //                }*/
            //                txbConfirm.Visible = false;
            //                lineShape3.Visible = false;
            //            }
            //            else
            //            {
            //                announce("Cap nhat that bai");
            //            }
            //        }
            //        else
            //        {
            //            announce("Cap nhat that bai");
            //        }
            //    }
            //    else
            //    {
            //        announce("Cap nhat that bai");
            //    }
            //    btnLogin.Text = "Login";
            //    label1.Text = "LOGIN";
            //    btnForgot.Text = "Forgot Password ?";
            //    btnConfirmCloseEye.Visible = false;
            //    btnConfirmOpenEye.Visible = false;
            //    btnCloseEye.BringToFront();
            //}
        }
        private void announce(string msg)
        {
            lbWelcome.Visible = true;
            lbWelcome.Text = msg;
            lbErrorMessage.Visible = false;
            txbConfirm.Visible = false;
            lineShape3.Visible = false;
            btnLogin.Text = "Login";
            txbPassword.Text = "PASSWORD";
            txbPassword.UseSystemPasswordChar = false;
            txbUser.Text = "USERNAME";
            lbErrorMessage.Visible = false;
            txbUser.Focus();
        }
        private void msgError(string msg)
        {
            lbWelcome.Visible = false;
            lbErrorMessage.Text = " " + msg;
            lbErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txbPassword.Text = "PASSWORD";
            txbPassword.UseSystemPasswordChar = false;
            txbUser.Text = "USERNAME";
            lbWelcome.Text = "WELCOME TO OUR SERVICES";
            lbErrorMessage.Visible = false;
            this.Show();
            txbUser.Focus();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (!txbPassword.UseSystemPasswordChar)
            {
                btnCloseEye.BringToFront();
                txbPassword.UseSystemPasswordChar = true;

            }
        }

        private void btnCloseEye_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar)
            {
                btnEye.BringToFront();
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnForgot.Text == "Forgot Password ?")
            {
                btnForgot.Text = "Return to login ??";
                txbPassword.Text = "PASSWORD";
                txbPassword.UseSystemPasswordChar = false;
                txbUser.Text = "USERNAME";
                txbConfirm.UseSystemPasswordChar = false;
                txbConfirm.Text = "CONFIRM PASSWORD";
                lbWelcome.Visible = false;
                lbErrorMessage.Visible = false;
                txbConfirm.Visible = true;
                lineShape3.Visible = true;
                btnConfirmCloseEye.Visible = true;
                btnConfirmOpenEye.Visible = true;
                btnLogin.Text = "Submit";
                txbUser.Focus();
                label1.Text = "FORGOT PASSWORD ?";
            }
            else
            {
                btnLogin.Text = "Login";
                label1.Text = "LOGIN";
                btnForgot.Text = "Forgot Password ?";
                btnConfirmCloseEye.Visible = false;
                btnConfirmOpenEye.Visible = false;
                txbPassword.Text = "PASSWORD";
                txbPassword.UseSystemPasswordChar = false;
                txbUser.Text = "USERNAME";
                lbWelcome.Visible = true;
                lbErrorMessage.Visible = false;
                txbConfirm.Visible = false;
                lineShape3.Visible = false;
                txbUser.Focus();
            }

        }

        private void btnConfirmOpenEye_Click(object sender, EventArgs e)
        {
            if (!txbConfirm.UseSystemPasswordChar)
            {
                btnConfirmCloseEye.BringToFront();
                txbConfirm.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirmCloseEye_Click(object sender, EventArgs e)
        {
            if (txbConfirm.UseSystemPasswordChar)
            {
                btnConfirmOpenEye.BringToFront();
                txbConfirm.UseSystemPasswordChar = false;
            }
        }

        private void returnToLogin(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_SignUp form = new Form_SignUp();
            form.Show();
            form.FormClosed += returnToLogin;
            this.Hide();
        }
    }
}
