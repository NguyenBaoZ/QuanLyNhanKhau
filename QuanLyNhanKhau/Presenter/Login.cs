using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanKhau.Model;
using QuanLyNhanKhau.View;
namespace QuanLyNhanKhau.Presenter
{
    public class Login
    {
        private readonly ModelHelper _repo;
        private readonly View.ILogin _form;
        public Login(View.ILogin form)
        {
            this._form = form;
            this._repo = ModelHelper.Instance;
        }
        public LoginState login()
        {
            if (this._form.Username == "ADMIN")
            {
                return LoginState.LOG_IN_MEMBER;
            }
            else if (this._form.Username == "USERNAME")
            {
                return LoginState.LOG_IN_MEMBER;

            }
            _repo.Auth.login(this._form.Username, this._form.Password);

            return _repo.Auth.loginState;

        }
    }
}
