using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Controllers
{
    public class HomeController : Controller
    {
        [Route("index")]
        [Route("")]
        public ActionResult Home()
        {
            return View();
        }
    }
}