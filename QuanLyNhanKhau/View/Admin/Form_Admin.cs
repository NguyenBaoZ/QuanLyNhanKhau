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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            //These lines eliminate the flickering of the form or controls in the graphical interface (But not 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        #region Load Data
        private void Form_NV_Load(object sender, EventArgs e)
        {
            if ("Admin" == "Admin")
            {
                btnSoHoKhau.Visible = true;
                btnDKTT.Visible = true;
                btnDKTV.Visible = true;
                //btnTimKiem.Visible = true;
                //btnBaoCao.Visible = true;
            }
            else
            {
                //loadMiniForm<Form_BanHang>();
            }
            loadData();
        }
        private void loadData()
        {
            /*lbAccountNumber.Text = datalogin.MaNV;
            lbName.Text = datalogin.TenNV;
            lbAccountName.Text = datalogin.TenTK;
            lbPosition.Text = datalogin.ViTri;*/
        }
        #endregion

        #region Load Base Form

        // RESIZE METHOD TO CHANGE SIZE TO FORM AT EXECUTION TIME ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------Dibujar rectangles Panel
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlControl.Region = region;
            this.Invalidate();
        }
        //----------------BOTTOM RECTANGLE COLOR AND GRIP
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon chac muon thoat chuong trinh khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Load Mini Form
        private void loadMiniForm<MiForm>() where MiForm : Form, new()
        {
            Form miniForm;
            // Find the collection for form
            miniForm = pnlInformation.Controls.OfType<MiForm>().FirstOrDefault();
            // If form isn't exist
            if (miniForm == null)
            {
                miniForm = new MiForm();
                miniForm.TopLevel = false;
                miniForm.FormBorderStyle = FormBorderStyle.None;
                miniForm.Dock = DockStyle.Fill;
                pnlInformation.Controls.Add(miniForm);
                pnlInformation.Tag = miniForm;
                miniForm.Show();
                miniForm.BringToFront();
            }
            else
            {
                miniForm.BringToFront();
            }
        }
        private void btnSoHoKhau_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Form_BanHang>();

            this.BackColor = Color.FromArgb(12, 61, 92);
            btnDKTV.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTT.BackColor = Color.FromArgb(4, 41, 68);
            //btnTimKiem.BackColor = Color.FromArgb(4, 41, 68);
            //btnBaoCao.BackColor = Color.FromArgb(4, 41, 68);
        }
        #endregion

        #region Menu Button
        private void btnDKTV_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Form_QLNV>();
            btnSoHoKhau.BackColor = Color.FromArgb(4, 41, 68);
            this.BackColor = Color.FromArgb(12, 61, 92);
            btnDKTT.BackColor = Color.FromArgb(4, 41, 68);
            //btnTimKiem.BackColor = Color.FromArgb(4, 41, 68);
            //btnBaoCao.BackColor = Color.FromArgb(4, 41, 68);
            btnLogout.BackColor = Color.FromArgb(4, 41, 68);
        }
        private void btnDKTT_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Form_QLDT>();
            btnSoHoKhau.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTV.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTT.BackColor = Color.FromArgb(12, 61, 92);
            //btnTimKiem.BackColor = Color.FromArgb(4, 41, 68);
            //btnBaoCao.BackColor = Color.FromArgb(4, 41, 68);
            btnLogout.BackColor = Color.FromArgb(4, 41, 68);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Form_TD>();
            btnSoHoKhau.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTV.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTT.BackColor = Color.FromArgb(4, 41, 68);
            //btnTimKiem.BackColor = Color.FromArgb(12, 61, 92);
            //btnBaoCao.BackColor = Color.FromArgb(4, 41, 68);
            btnLogout.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Form_KHTT>();
            btnSoHoKhau.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTV.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTT.BackColor = Color.FromArgb(4, 41, 68);
            //btnTimKiem.BackColor = Color.FromArgb(4, 41, 68);
            //btnBaoCao.BackColor = Color.FromArgb(12, 61, 92);
            btnLogout.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            //loadMiniForm<Profile>();
        }

        private void btnCapSoHoKhau_Click(object sender, EventArgs e)
        {
            loadMiniForm<View.Form_ChuyenKhau>();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnSoHoKhau.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTV.BackColor = Color.FromArgb(4, 41, 68);
            btnDKTT.BackColor = Color.FromArgb(4, 41, 68);
            //btnTimKiem.BackColor = Color.FromArgb(4, 41, 68);
            //btnBaoCao.BackColor = Color.FromArgb(4, 41, 68);
            this.BackColor = Color.FromArgb(12, 61, 92);
            DialogResult result = MessageBox.Show("Ban co chac muon dang xuat khoi tai khoan nay khong ?", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if(pnlButton.Width == 271)
            //{
            //    pnlButton.Width = 50;
            //    btnMenu.Location =  new Point (0,0);
            //    pbProfile.Visible = false;
            //    pbMiniProfile.Visible = true;
            //}
            //else
            //{
            //    pnlButton.Width = 271;
            //    btnMenu.Location = new Point(231, 0); 
            //    pbProfile.Visible = true;
            //    pbMiniProfile.Visible = false;
            //}
        }
        #endregion
    }
}
