using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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

            #region Init EF - Brug denne kode til oprettelse af brugere
            //using (var context = new DatingContext())
            //{
            //    context.Users.Add(new User
            //    {
            //        Name = "Camilla Hansen",
            //        LoginName = "YogaGal93",
            //        PassCode = "GodtPassword",
            //        Birthday = DateTime.ParseExact("1993-12-01", "yyyy-MM-dd", CultureInfo.CurrentCulture),
            //        CreateDate = DateTime.UtcNow
            //    });

            //    context.SaveChanges();
            //}



            //using (var context = new DatingContext())
            //{
            //    context.Profiles.Add(new Profile
            //    {
            //        ID = 5,
            //        Picture = "https://i.kinja-img.com/gawker-media/image/upload/s--94JUxrpM--/c_scale,f_auto,fl_progressive,q_80,w_800/zjeabjityzca61on7izk.jpg",
            //        Description = "25 år gammel. Elsker sport, fitness og hyggelige stunder på sofaen.",
            //        User = context.Users.Where(x => x.ID == 5).First(),
            //        Height = 184,
            //        Weight = 68,
            //        Gender = "Female",
            //        BodyType = "Trained",
            //        HairColor = "Red",
            //        EyeColor = "Brown"
            //    });

            //    context.SaveChanges();
            //}


            #endregion Init EF

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your about page.";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your profile page.";

            return View();
        }

        public ActionResult Browse()
        {
            ViewBag.Message = "Your match browsing page.";

            return View();
        }
    }
}