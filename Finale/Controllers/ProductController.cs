using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.Controllers
{
    [Route("Products")]
    public class ProductController : Controller
    {
        [Route("{name}")]
        public ActionResult Index(string name)
        {
            // db get product details 

            return View();
        }
    }
}