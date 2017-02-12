using Finale.UI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Finale.UI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserVM credentials)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult LogOff()
        {
            return View();
        }
    }
}