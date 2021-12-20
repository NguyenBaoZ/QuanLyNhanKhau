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
    public interface ISignUp
    {
        string Password { get; }
        string Repassword { get; }
        string Username { get; }
        string CCID { get; }
    }
    public partial class Form_SignUp : Form, ISignUp
    {
        public string Password { get { return this.txbPassword.Text; } }

        public string Repassword { get { return this.txbConfirm.Text; } }

        public string Username { get { return this.txbUser.Text; } }

        public string CCID { get { return this.txtCCCD.Text; } }
        private Presenter.SignUp _present { get; set; }

        public Form_SignUp()
        {
            InitializeComponent();

            this._present = new Presenter.SignUp(this);
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
        private void announce(string msg)
        {

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
            lbErrorMessage.Text = " " + msg;
            lbErrorMessage.BringToFront();
            lbErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txbPassword.Text = "PASSWORD";
            txbPassword.UseSystemPasswordChar = false;
            txbUser.Text = "USERNAME";
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
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            Console.Write("Login");
            if (this.Password == this.Repassword)
            {
                var kq = this._present.signUp();
                if (kq == Model.SignUpState.SUCCEED)
                {
                    // load login form
                    msgError("Đăng kí Thành công");
                }
                else
                {
                    msgError("Đăng kí thất bại");
                }
            }
            else
            {
                msgError("password không trùng khớp");
            }
        }
    }
}
