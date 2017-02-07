using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.Controllers
{
    public class BaseController : Controller
    {
        Finale.BLL.Service.service service = new Finale.BLL.Service.service();
    }
}