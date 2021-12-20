using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanKhau.Model;
using QuanLyNhanKhau.View;
namespace QuanLyNhanKhau.Presenter
{
    public class SignUp
    {
        private readonly ModelHelper _repo;
        private readonly ISignUp _form;
        public SignUp(ISignUp form)
        {
            this._form = form;
            this._repo = ModelHelper.Instance;
        }
        public SignUpState signUp()
        {
            return this._repo.Auth.signUp(this._form.Username, this._form.Password, this._form.CCID);
        }
    }
}
