using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanKhau.Model
{
    public enum LoginState
    {
        LOG_IN_MEMBER,
        LOG_IN_ADMIN,
        LOG_IN_MODERATOR,
        LOG_OUT,
    }
    public class Authentication
    {
        public User currentUser { get; private set; } = null;
        public LoginState loginState
        {
            get
            {
                if (this.currentUser == null)
                {
                    return LoginState.LOG_OUT;
                }
                {
                    switch (this.currentUser.Role)
                    {
                        case "MEMBER":
                            return LoginState.LOG_IN_MEMBER;
                        case "ADMIN":
                            return LoginState.LOG_IN_ADMIN;
                        case "MODERATOR":
                            return LoginState.LOG_IN_MODERATOR;
                        default:
                            return LoginState.LOG_OUT;
                    }
                }
            }
        }
        private QuanLyNhanKhauDBSchemaEntities ctx = new QuanLyNhanKhauDBSchemaEntities();
        public bool isLogin()
        {
            return currentUser != null;
        }
        public User login(string email, string password)
        {
            var user = (from p in ctx.Users
                        where p.Email == email && p.Password == password
                        select p).Take(1).First();
            if (user != null)
            {
                this.currentUser = user;
                return this.currentUser;
            }
            return null;
        }
        public User signUp(string email, string password, string cccid)
        {
            var details = (from p in ctx.CitizenDetails
                           where p.CCCDId == cccid
                           select p).Take(1).First();
            var newuser = new User() { Email = email, Password = password };
            if (details != null)
            {
                newuser.CitizenDetails.Add(details);
            }
            this.currentUser = this.ctx.Users.Add(newuser);
            return this.currentUser;
        }
    }
}
