using System;
using System.Windows.Forms;
using System.Data.Entity.Core;
using System.Globalization;
namespace QuanLyNhanKhau
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.CurrentCulture = new CultureInfo("vi-VN");
                var form = new View.Form_Login();
                Application.Run(form);
            }
            catch (EntityException err)
            {
                MessageBox.Show(err.Message + "\n" + "Database isn't existed");
            }
        }
    }
}
