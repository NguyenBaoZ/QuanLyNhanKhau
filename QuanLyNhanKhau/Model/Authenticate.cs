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
    public static class LoginStateImp
    {
        public static LoginState Parser(string s)
        {
            Console.WriteLine("Parser run 2 " + s + (s == "MEMBER"));
            switch (s.Trim())
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
        public static string ToString(this LoginState e)
        {
            switch (e)
            {
                case LoginState.LOG_IN_MEMBER:
                    return "MEMBER";
                case LoginState.LOG_IN_ADMIN:
                    return "ADMIN";
                case LoginState.LOG_IN_MODERATOR:
                    return "MODERATOR";
                default:
                    return "";
            }
        }
    }
    public enum SignUpState
    {
        USER_EXISTED,
        SUCCEED,
        FAIL,
    }
    public class Authentication
    {
        public User currentUser { get; private set; } = null;
        public LoginState loginState
        {
            get
            {
                Console.WriteLine(this.currentUser.Role + this.currentUser.Email + this.currentUser == null);
                if (this.currentUser == null)
                {
                    return LoginState.LOG_OUT;
                }
                else
                {
                    Console.WriteLine("Parser run");
                    return LoginStateImp.Parser(this.currentUser.Role);
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
                        select p).FirstOrDefault();
            if (user != null)
            {
                this.currentUser = user;
                return this.currentUser;
            }
            return null;
        }
        public SignUpState signUp(string email, string password, string cccid)
        {
            var details = (from p in ctx.CitizenDetails
                           where p.CCCDId == cccid
                           select p).FirstOrDefault();
            var newuser = new User() { Email = email, Password = password };
            if (details != null)
            {
                newuser.CitizenDetails.Add(details);
            }
            Console.WriteLine(newuser.Email + " " + newuser.Password);
            //this.currentUser = ctx.Users.Add(newuser);
            ctx.Users.Add(newuser);
            ctx.SaveChanges();
            return SignUpState.SUCCEED;
        }
    }
}
