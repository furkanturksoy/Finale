using Finale.BLL.Service;
using Finale.UI.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        service service = new service();

        [Route("admin/products/list")]
        public ActionResult Products()
        {
            var model = service.CategoryService.GetAll().Select(x => new CategoryDTO()
            {
                Name = x.Name
            }).ToList();

            return View("~/Areas/Admin/Views/Product/Products.cshtml", model);
        }
    }
}