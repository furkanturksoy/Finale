using Finale.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace Finale.UI.Controllers
{
    public class AccountApiController : baseApiController
    {

        


        [HttpPost]
        [Route("account/login")]
        public dynamic Login(userCredentialsDTO credentials)
        {
            if (ModelState.IsValid)
            {
                bool exist = service.User.Any
                    (x => x.UserName == credentials.Username && x.Password == credentials.Password);

                if (exist)
                {
                    string cookie =
                        service.User.Where
                        (x => x.UserName == credentials.Username && x.Password == credentials.Password)
                        .Select(x => x.UserID + "," + x.UserName).SingleOrDefault();

                    FormsAuthentication.SetAuthCookie(cookie, true);
                    return true;


                }else
                {
                    
                    return "Username Or Password Is Wrong";
                }

            }
            else
            {
                return false;
            }

        }


        [HttpPost]
        [Route("account/register")]
        public bool Register(registerCredentialsDTO registerCredentials)
        {
            if (ModelState.IsValid)
            {
                if(service.User.Any(x => x.UserName == registerCredentials.Username))
                {
                    return false;
                }
                Finale.DAL.Entity.User user = new DAL.Entity.User();

                user.UserName = registerCredentials.Username;
                user.Password = registerCredentials.Password;
                user.UserDetails = new DAL.Entity.UserDetail()
                {
                    Address = registerCredentials.Address,
                    FirstName = registerCredentials.Firstname,
                    LastName = registerCredentials.Lastname
                };
                user.ShoppingCart = new DAL.Entity.ShoppingCart();
                try
                {
                    service.User.Add(user);
                    int rows = service.SaveChanges();

                    return rows > 0;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }


        public class userCredentialsDTO
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class registerCredentialsDTO
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Address { get; set; }
        }
    }
}
