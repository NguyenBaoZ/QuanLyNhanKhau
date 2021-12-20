using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanKhau.util;
namespace QuanLyNhanKhau.Model
{
    public class DetailRepository
    {
        ModelHelper _modelhelper = ModelHelper.Instance;
        private QuanLyNhanKhauDBSchemaEntities ctx = new QuanLyNhanKhauDBSchemaEntities();
        public CitizenDetail updateCurrentDetail(Location address, DateTime BirthDate, string phone, string email, string cccid, string Gender, Location CCCDProvideAddress, DateTime CCCDProvideDate, string CCCDProvideUrgent)
        {
            var cur = _modelhelper.Auth.currentUser;
            if (cur.CitizenDetails.FirstOrDefault() == null)
            {
                var citizendetail = new CitizenDetail() { Address = address.ToString(), BirthDate = BirthDate, Phone = phone, ContactEmail = email, CCCDId = cccid, CCCDProvideAddress = CCCDProvideAddress.ToString(), CCCDProvideDate = CCCDProvideDate, CCCDProvideUrgent = CCCDProvideUrgent };
                cur.CitizenDetails.Add(citizendetail);
            }
            else
            {
                var details = cur.CitizenDetails.FirstOrDefault();
                details.Address = address.ToString();
                details.BirthDate = BirthDate;
                details.Phone = phone;
                details.ContactEmail = email;
            }
            ctx.Users.Attach(cur);
            ctx.SaveChangesAsync();
            return cur.CitizenDetails.FirstOrDefault();
        }
    }
}
