using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DatingApplication.Controllers
{
    public class LoginRequest
    {
        public string Password { get; set; }
        public string Username { get; set; }
    }

    public static class UserValidation
    {
        public static bool Verify(LoginRequest request)
        {

            if (request == null)
            {
                return false;
            }
            using (var ctx = new DatingContext())
            {
                var user = ctx.Users.FirstOrDefault(x => x.LoginName == request.Username);
                return user.PassCode == request.Password;
            }

            
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
    }
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool UserLogin([FromBody]LoginRequest request)
        {
            return UserValidation.Verify(request);
            
        }

        public void UserLogout()
        {

        }

        [HttpPost]
        public void CreateUser([FromBody]Models.User value)
        {
            value.CreateDate = DateTime.UtcNow;
            using (var ctx = new DatingContext())
            {
                ctx.Users.Add(value);
                ctx.SaveChanges();
            }
        }
    }
}