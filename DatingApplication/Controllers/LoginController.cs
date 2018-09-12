using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
}
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool UserLogin([FromBody]LoginRequest request)
        {
            return UserValidation.Verify(request);
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