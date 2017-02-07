using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.Controllers
{
    [Route("Categories")]
    public class CategoryController : Controller
    {
        
        [Route("")]
        [Route("{name}")]
        public ActionResult List(string name)
        {
            if(name != null)
            {

            }else if(name == null)
            {

            }else
            {
                
            }
        }


    }
}