using QuanLyNhanKhau.View.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhau.View.User
{
    public partial class Form_DoiNhanKhau : Form
    {
        public Form_DoiNhanKhau()
        {
            InitializeComponent();
        }
        private void loadMiniForm<MiForm>() where MiForm : Form, new()
        {
            Form miniForm;
            // Find the collection for form
            miniForm = pnlSelfInfo.Controls.OfType<MiForm>().FirstOrDefault();
            // If form isn't exist
            if (miniForm == null)
            {
                miniForm = new MiForm();
                miniForm.TopLevel = false;
                miniForm.FormBorderStyle = FormBorderStyle.None;
                miniForm.Dock = DockStyle.Fill;
                pnlSelfInfo.Controls.Add(miniForm);
                pnlSelfInfo.Tag = miniForm;
                miniForm.Show();
                miniForm.BringToFront();
            }
            else
            {
                miniForm.BringToFront();
            }
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            loadMiniForm<Form_SelfInfo>();
        }
    }
}
