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
        private readonly ModelHelper _repository;
        private readonly View.ILogin _form;
        public Login(View.ILogin form)
        {
            this._form = form;
            this._repository = ModelHelper.Instance;
        }
        public LoginState login()
        {
            _repository.login(this._form.Username, this._form.Password);

            //return _repository.loginState;
            return LoginState.LOG_IN_MEMBER;
        }
    }
}
