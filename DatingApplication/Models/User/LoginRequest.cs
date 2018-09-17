using System.Linq;
using System.Web;

namespace DatingApplication.Models
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
}