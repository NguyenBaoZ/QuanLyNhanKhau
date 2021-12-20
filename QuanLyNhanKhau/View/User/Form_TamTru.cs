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
    public partial interface ITamTru
    {
        string TenChuHo { get; set; }
        DateTime ngaySinh { get; set; }
        string CMND { get; set; }
        DateTime NgayCap { get; set; }
        string NoiCap { get; set; }
        string NoiSinh { get; set; }
        DateTime ThoiGianTamTru { get; set; }
        DateTime TamTruDenNgay { get; set; }
        Location NoiDangKiTamTru { get; set; }
        string Lydo { get; set; }
    }
    public partial class Form_TamTru : Form, ITamTru
    {
        Presenter.User.TamTruPresenter _presenter;
        public Form_TamTru()
        {
            InitializeComponent();
            this._presenter = new Presenter.User.TamTruPresenter(this); ;
        }
        public string TenChuHo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ngaySinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CMND { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime NgayCap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiCap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiSinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ThoiGianTamTru { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime TamTruDenNgay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiDangKiTamTru { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lydo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void XacNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
