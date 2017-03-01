using Finale.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Finale.UI.Controllers
{
    public class baseApiController : ApiController
    {
        public FinaleContext service { get; set; }
        public baseApiController()
        {
            service = new FinaleContext();
        } 
    }
}
