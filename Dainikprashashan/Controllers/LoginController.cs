
using Dainikprashashan.Models;
using Dainikprashashan.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dainikprashashan.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet] //Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost] //Register
        public ActionResult Register(Login l)
        {
            var lservice = new Loginservice();
            var response = lservice.SaveRegister(l);
            return RedirectToAction("Register", "Login");
        }

        [HttpGet] //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] //Login
        public ActionResult Login(Login lo)
        {
            var loginsuccess = new Loginservice();
            var response = loginsuccess.SaveLogin(lo);
            var LOGINiD = response.Item2;
            Session["LoginId"] = response.Item2;
            if (response.Item1 == "true")
            {
                return RedirectToAction("Home", "Dashboard");
            }
            else
            {
                return View();
            }

        }

    }
}