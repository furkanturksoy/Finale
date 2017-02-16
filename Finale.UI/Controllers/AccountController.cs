using Finale.UI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Finale.UI.Controllers
{
    public class AccountController : BaseController
    {
        [Route("account/register")]
        public ActionResult Register()
        {
            ViewBag.Context = HttpContext;
            return View("~/Views/Account/Register.cshtml");
        }
        
        [HttpPost]
        [Route("account/register")]
        public ActionResult Register(UserDTO userCredentials)
        {
            if (ModelState.IsValid)
            {
                if (service.User.SingleOrDefault
                    (x => x.UserName == userCredentials.Username) == null)
                {
                    Finale.DAL.Entity.User user = new Finale.DAL.Entity.User()
                    {
                        UserName = userCredentials.Username,
                        Password = userCredentials.Password,
                        ShoppingCart = new DAL.Entity.ShoppingCart(),
                        UserDetails = new Finale.DAL.Entity.UserDetail()
                         {

                             FirstName = userCredentials.Firstname,
                             LastName = userCredentials.Lastname,
                             Address = userCredentials.Address,

                         }
                    };

                    service.User.Add(user);
                    service.SaveChanges();

                }

            }
            return Redirect("/index");
        }
        [Route("account/login")]
        public ActionResult Login()
        {
            ViewBag.Context = HttpContext;
            return View("~/Views/Account/Login.cshtml");
        }

        [HttpPost]
        [Route("account/login")]
        public ActionResult Login(string username, string password)
        {

            var user = service.User.Where(x => x.UserName == username && x.Password == password).Select(x => x.UserName + "," + x.UserID).SingleOrDefault();

            if (!string.IsNullOrEmpty(user)) {
                FormsAuthentication.SetAuthCookie(user, true);
                return Redirect("/index");
            }else
            {
                return Redirect("/account/login"); // error message
            }


        }

        [Route("/account/logout")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/index");
        }
    }
}