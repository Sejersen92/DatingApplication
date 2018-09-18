using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
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
            //    context.Users.Add(new Profile
            //    {
            //        Picture = "",
            //        Description = "",
            //        Height = 166,
            //        Weight = 72,
            //        Gender = "",
            //        BodyType = "",
            //        HairColor = "",
            //        EyeColor = ""
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
            var login = UserValidation.GetLogin(Request);

            if (UserValidation.Verify(login))
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
            return RedirectToAction("Login", "Home");
        }

        public ActionResult LogOut()
        {
            return RedirectToAction("Index","Home");
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Register.";

            return View();
        }
        public ActionResult ProfileInfo()
        {
            return View();
        }
    }
}