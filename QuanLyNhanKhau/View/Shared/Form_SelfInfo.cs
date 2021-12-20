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
    public partial interface ISelfInfo
    {
        string HoTen { get; set; }
        DateTime NgaySinh { get; set; }
        string CMND { get; set; }
        DateTime NgayCap { get; set; }
        string NoiSinh { get; set; }
        string SDTLienHe { get; set; }
        Location NoiTamTru { get; set; }
    }
    public partial class Form_SelfInfo : Form
    {
        public Form_SelfInfo()
        {
            InitializeComponent();
        }
    }
}
