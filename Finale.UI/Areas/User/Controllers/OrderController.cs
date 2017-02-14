using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.User.Controllers
{
    public class OrderController : Controller
    {
        [Route("user/{userid}/panel/orders")]
        public ActionResult Orders()
        {
            return View();
        }

        [Route("user/{userid}/panel/orders/{orderid}/details")]
        public ActionResult OrderDetails()
        {
            return View();
        }
    }
}