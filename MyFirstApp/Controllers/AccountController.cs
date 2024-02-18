using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string username , string password)
        {
            if (username == "huy" && password == "123" )
            {
                return RedirectToAction("Dashboard","Admin");
            }
            else
            {
                return RedirectToAction("Invalidlogin");
            }
        }
        public ActionResult Invalidlogin()
        {
            return View();
        }
    }
}