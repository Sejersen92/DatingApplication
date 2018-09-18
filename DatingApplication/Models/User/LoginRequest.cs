using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingApplication
{
    public class LoginRequest
    {
        public string Password { get; set; }
        public string Username { get; set; }
    }

    public class UserValidation
    {
        public static bool Verify(LoginRequest request)
        {
            if (request == null)
            {
                return false;
            }
            var user = GetUser(request);
            if (user == null)
            {
                return false;
            }
            return user.PassCode == request.Password;
        }

        public static LoginRequest GetLogin(HttpRequestBase request)
        {
            var usr = request.Cookies["Username"]?.Value;
            var pw = request.Cookies["Password"]?.Value;
            if (pw != null && usr != null)
            {
                return new LoginRequest()
                {
                    Password = pw,
                    Username = usr
                };
            }
            return null;
        }

        public static User GetUser(LoginRequest request)
        {
            using (var ctx = new DatingContext())
            {
                return ctx.Users.FirstOrDefault(x => x.LoginName == request.Username);
            }
        }
    }
}