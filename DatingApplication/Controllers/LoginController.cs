using DatingApplication.Models;
using System;
using System.Web.Http;

namespace DatingApplication.Controllers
{
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