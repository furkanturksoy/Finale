using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Finale.UI.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("account/login")]
        public bool Login()
        {
            return true;
        }

        [HttpPost]
        [Route("account/register")]
        public bool Register()
        {
            return true;
        }

    }

    public class userCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class registerCredentials
    {
        public userCredentials credentials { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
    }
}
