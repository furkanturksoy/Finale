using Finale.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            FinaleContext service = new FinaleContext();
        }


    }
}