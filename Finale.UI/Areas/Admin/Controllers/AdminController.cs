using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.Admin.Controllers
{

    public class AdminController : Controller
    {
        string path = "~/Areas/Admin/Views/Admin/Views";

        [Route("admin")]      
        public ActionResult Index()
        {
            return View(path+"/Index.cshtml");
        }

    }
}