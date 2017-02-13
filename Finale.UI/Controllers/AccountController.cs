using Finale.BLL.Service;
using Finale.DAL.ORM.Entity;
using Finale.UI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Finale.UI.Controllers
{
    public class AccountController : Controller
    {
        service service = new service();
        [HttpGet]
        [Route("account/register")]
        public ActionResult Register()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) { 
            ViewBag.Context = HttpContext;
            return View("~/Views/Account/Register.cshtml");
            }
            return Redirect("/index");
        }

        [HttpPost]
        [Route("account/register")]
        public ActionResult Register(UserVM credentials)
        {
            Customer customer = new Customer()
            {
                UserName = credentials.Username,
                Password = credentials.Password,
                CustomerDetails = new CustomerDetails()
                {
                    FirstName = credentials.FirstName,
                    LastName = credentials.LastName,
                    Address = credentials.Address
                },
                ShoppingCart = new ShoppingCart()
                {
                    isActive = true,
                    Items = new List<Item>(),

                },
                isActive = true

            };
            service.CustomerService.Add(customer);


            return Redirect("/index");
        }
        [HttpGet]
        [Route("account/login")]
        public ActionResult Login()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) {
                ViewBag.Context = HttpContext;
                return View();
            }else
            {
                return Redirect("/index");
            }
           
        }

        [HttpPost]
        [Route("account/login")]
        public ActionResult Login(string Username, string Password)
        {
            bool isExists = service.CustomerService.Any(x => x.UserName == Username && x.Password == Password);
            Customer customer;
            string cookie;
            if(isExists == true)
            {
                customer = service.CustomerService.GetOneByCondition(x => x.UserName == Username && x.Password == Password);
                cookie = string.Format("{0},{1},{2}", customer.UserName, customer.CustomerDetails.FirstName, customer.ID);

                FormsAuthentication.SetAuthCookie(cookie, true);

                return Redirect("/index");
            }else {

                return Redirect("/account/login");
            }

            
        }


        [Route("account/logout")]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Managers.AuthManager.Null();
            return Redirect("/index");
        }
    }
}