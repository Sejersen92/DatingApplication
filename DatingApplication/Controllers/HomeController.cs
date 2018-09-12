using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatingApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            #region Init EF
            //using (var context = new DatingContext())
            //{
            //    context.Users.Add(new User
            //    {
            //        Name = "Mikkel Sejersen",
            //        LoginName = "Kongen",
            //        PassCode = "GodtPassword",
            //        Birthday = DateTime.UtcNow,
            //        CreateDate = DateTime.UtcNow
            //    });

            //    context.SaveChanges();
            //}

            #endregion Init EF
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public new ActionResult Profile()
        {
            var usr = Request.Cookies["Username"]?.Value;
            var pw = Request.Cookies["Password"]?.Value;
                if (pw != null && usr != null)
                {
                    var login = new LoginRequest()
                    {
                        Password = pw,
                        Username = usr
                    };
                    if (UserValidation.Verify(login))
                    {
                        ViewBag.Message = "Your contact page.";

                        return View();
                    }
                }
            return RedirectToAction("Login", "Account");

        }
    }
}