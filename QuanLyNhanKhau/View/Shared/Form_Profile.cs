using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanKhau.util;
namespace QuanLyNhanKhau.View.Shared
{
    public partial interface IThongTinCaNhan
    {
        string HoTen { get; set; }
        DateTime NgaySinh { get; set; }
        string CMND { get; set; }
        string NoiCap { get; set; }
        string NgayCapCMND { get; set; }
        EGioiTinh GioiTinh { get; set; }
        DateTime NgayCapSHK { get; set; }
        string MaSHK { get; set; }
        string SDTLienHe { get; set; }
        string Email { get; set; }
        string NoiSinh { get; set; }
        Location NoiOHienTai { get; set; }
        Location NoiCapSoHoKhau { get; set; }
    }
    public partial class Form_Profile : Form
    {
        public Form_Profile()
        {
            InitializeComponent();
        }
        public void showSelfProfile()
        {
            panel2.Visible = false;
        }
    }
}
