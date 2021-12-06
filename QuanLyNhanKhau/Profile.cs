using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Getdata;
using model;

namespace GiaoDien__NhanVien_
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            passEditControl();
        }
        private void loadData()
        {
            pnl_edit.Visible = false;
            lbl_tenNV.Text = datalogin.TenNV;
            lbl_gioitinh.Text = datalogin.GIOITINH;
            lbl_ngaysinh.Text = datalogin.NGAYSINH.ToLongDateString();
            lbl_sdt.Text = datalogin.SDT;
            lbl_diachi.Text = datalogin.DiaChi;
            txt_mkxn.Text = "";


            //edit
            txt_ten.Text = datalogin.TenNV;
            txt_diachi.Text = datalogin.DiaChi;
            txt_gt.Text = datalogin.GIOITINH;
            txt_sdt.Text = datalogin.SDT;
            txt_tk.Text = datalogin.TenTK;
            txt_mk.Text = datalogin.MatKhau;
            txt_mklan2.Text = datalogin.MatKhau;
            data_ngaysinh.Value = datalogin.NGAYSINH;


        }
        private void passEditControl()
        {
            link_changeMK.Text = "edit";
            txt_mk.Enabled = false;
            txt_mk.UseSystemPasswordChar = true;
            txt_mklan2.Enabled = false;
            txt_mklan2.UseSystemPasswordChar = true;
            txt_mkxn.UseSystemPasswordChar = true;

        }
        private void link_edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_edit.Visible = true;
        }
        private void reset()
        {
            loadData();
            passEditControl();
        }
        private void btt_cancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btt_save_Click(object sender, EventArgs e)
        {

            if (txt_mk.Text == txt_mklan2.Text)
            {
                if (txt_mkxn.Text == datalogin.MatKhau)
                {
                    var userModel = new Usermodel(
                         maNV: datalogin.MaNV,
                         tenNV: txt_ten.Text,
                         tenTK: txt_tk.Text,
                         mK: txt_mk.Text,
                         gt: txt_gt.Text,
                         dC: txt_diachi.Text,
                         sDT: txt_sdt.Text,
                         ngaysinh: data_ngaysinh.Value
    );
                    var result = userModel.EditUserProfile();
                    MessageBox.Show(result);
                    reset();

                }
                else MessageBox.Show("sai mat khau, vui long nhap lai ", "thong bao", MessageBoxButtons.OK);
            }
            else MessageBox.Show("2 mat khau phai trung nhau", "thong bao", MessageBoxButtons.OK);

        }

        private void link_changeMK_Click(object sender, EventArgs e)
        {
            if (link_changeMK.Text == "edit")
            {
                link_changeMK.Text = "cancel";
                txt_mk.Enabled = true;
                txt_mk.Text = "";
                txt_mklan2.Enabled = true;
                txt_mklan2.Text = "";

            }
            else reset();
        }
    }
}
