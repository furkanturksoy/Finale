using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.User.Controllers
{
    public class CartController : UI.Controllers.BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}