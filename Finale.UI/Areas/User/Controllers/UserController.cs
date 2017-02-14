using Finale.BLL.Service;
using Finale.DAL.ORM.Entity;
using Finale.UI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Finale.UI.Areas.User.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        service service = new service();

        [Route("user/panel")]
        public ActionResult Panel()
        {
            ViewBag.Context = HttpContext;
            ViewBag.UserID = Managers.AuthManager.CurrentUserID;
            return View("~/Areas/User/Views/User/Panel.cshtml");
        }

        [Route("user/panel/details")]
        public ActionResult Details()
        {
            Customer user = service.CustomerService.GetOneByID(Managers.AuthManager.CurrentUserID);

            UserVM model = new UserVM()
            {
                Address = user.CustomerDetails.Address,
                FirstName = user.CustomerDetails.FirstName,
                LastName = user.CustomerDetails.LastName,
                Username = user.UserName
            };

            ViewBag.UserID = Managers.AuthManager.CurrentUserID;
            return View("~/Areas/User/Views/User/Details.cshtml", model);
        }


        [Route("user/panel/edit-details")]
        public ActionResult EditDetails()
        {
            


            ViewBag.UserID = Managers.AuthManager.CurrentUserID;

            Customer user = service.CustomerService.GetOneByID(Managers.AuthManager.CurrentUserID);
            UserVM model = new UserVM()
            {
                Address = user.CustomerDetails.Address,
                FirstName = user.CustomerDetails.FirstName,
                LastName = user.CustomerDetails.LastName,
                Username = user.UserName
            };
            return View("~/Areas/User/Views/User/updateDetails.cshtml", model);
        }

        [Route("user/panel/edit-details")]
        [HttpPost]
        public ActionResult EditDetails(UserVM details)
        {
            Customer updated = service.CustomerService.GetOneByID(Managers.AuthManager.CurrentUserID);
            string cookie;

            updated.UserName = details.Username;
            updated.CustomerDetails.FirstName = details.FirstName;
            updated.CustomerDetails.Address = details.Address;
            updated.CustomerDetails.LastName = details.LastName;
            service.CustomerService.Save();

            cookie = string.Format("{0},{1},{2}", updated.UserName, updated.CustomerDetails.FirstName, updated.ID);

            Managers.AuthManager.Null();
            FormsAuthentication.SignOut();

            FormsAuthentication.SetAuthCookie(cookie, true);


            return Redirect("/user/panel/details");
        }
    }
}