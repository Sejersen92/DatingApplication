using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatingApplication.Controllers
{
    public class AccountController : Controller
    {
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
    }
}