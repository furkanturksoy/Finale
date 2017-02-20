using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Finale.UI.Controllers
{
    public class LogInController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public string Post(credentials credent)
        {
            return credent.Username + " " + credent.Password;
        }
    }

    public class credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
