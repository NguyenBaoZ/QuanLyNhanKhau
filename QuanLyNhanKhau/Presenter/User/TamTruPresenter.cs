using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanKhau.Repository;
using QuanLyNhanKhau.Model;
namespace QuanLyNhanKhau.Presenter.User
{
    public class TamTruPresenter
    {
        private readonly RequestRepository _repo;
        private readonly ModelHelper _modelHelper;
        private readonly View.ITamTru _form;
        public TamTruPresenter(View.ITamTru form)
        {
            this._form = form;
            this._repo = new RequestRepository();
        }
        void createNew()
        {
            var newreq = _repo.createTamTruRequest(_modelHelper.Auth.currentUser, _form.Lydo, _form.TamTruDenNgay);
        }
        void updateCurrent()
        {

        }
    }
}
