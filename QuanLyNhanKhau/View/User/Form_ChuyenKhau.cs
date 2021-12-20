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
using QuanLyNhanKhau.Model;
namespace QuanLyNhanKhau.View
{
    public partial interface IChuyenKhau
    {
        string TenChuHo { get; set; }
        DateTime ngaySinh { get; set; }
        string NoiCap { get; set; }
        string Email { get; set; }
        string SDTLienHe { get; set; }
        string NoiSinh { get; set; }
        Location NoiTamTru { get; set; }
        Location NoiOHienTai { get; set; }
        Location NoiChuyenDen { get; set; }
        string Denghi { get; set; }
        List<Model.User> DanhSachThanhVienCungThayDoi { get; set; }
    }
    public partial class Form_ChuyenKhau : Form, IChuyenKhau
    {
        public Form_ChuyenKhau()
        {
            InitializeComponent();
        }

        public string TenChuHo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ngaySinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiCap { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SDTLienHe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NoiSinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiTamTru { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiOMuonDangKi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Denghi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Model.User> DanhSachThanhVienCungThayDoi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiOHienTai { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Location NoiChuyenDen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
