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
namespace QuanLyNhanKhau.View
{
    public partial interface ISoHoKhau
    {
        string TenChuHo { get; set; }
        DateTime ngaySinh { get; set; }
        string NoiCap { get; set; }
        string Email { get; set; }
        string SDTLienHe { get; set; }
        string NoiSinh { get; set; }
        Location NoiTamTru { get; set; }
        Location NoiOMuonDangKi { get; set; }
        string Denghi { get; set; }
        List<Model.User> DanhSachThanhVienCungThayDoi { get; set; }
    }
    public partial class Form_SoHoKhau : Form
    {
        public Form_SoHoKhau()
        {
            InitializeComponent();
        }
    }
}
