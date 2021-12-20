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
    interface ITamVang
    {
        string TenChuHo { get; set; }
        DateTime ngaySinh { get; set; }
        string CMND { get; set; }
        DateTime NgayCap { get; set; }
        string NoiCap { get; set; }
        string NoiSinh { get; set; }
        DateTime ThoiGianTamTru { get; set; }
        DateTime TamTruDenNgay { get; set; }
        Location NoiDangKiTamVang { get; set; }
        string Lydo { get; set; }
    }
    public partial class Form_TamVang : Form, ITamVang
    {

        public Form_TamVang()
        {
            InitializeComponent();
        }

        public string TenChuHo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ngaySinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CMND { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime NgayCap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiCap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiSinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ThoiGianTamTru { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TamTruDenNgay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiDangKiTamVang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lydo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
