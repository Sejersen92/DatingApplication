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

            using(var context = new DatingContext())
            {
                context.Users.Add(new User
                {
                    Name = "Mikkel Sejersen",
                    LoginName = "Kongen",
                    PassCode = "GodtPassword",
                    Birthday = DateTime.UtcNow,
                    CreateDate = DateTime.UtcNow
                });

                context.SaveChanges();
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}