using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Finale.UI.Controllers
{
    public class AccountMvcController : Controller
    {
        // GET: AccountController2

        [HttpGet]
        [Route("account/logout")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/index");
        }
    }
}