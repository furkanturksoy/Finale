using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.User.Controllers
{
    public class PanelController : UI.Controllers.BaseController
    {
        public ActionResult Panel()
        {
            return View();
        }
    }
}