using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Finale.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {

        [Route("admin/product/{categoryname}/page/{id?}")]
        public IActionResult Products(int id, string categoryname)
        {
            return View();
        }

        [Route("admin/product/{productname}")]
        public IActionResult Product(string name)
        {
            return View();
        }
        [Route("admin/product/{productname}/update")]
        public IActionResult UpdateProduct()
        {
            return View();
        }

        [Route("admin/product/{productname}/deactivate")]
        public IActionResult DeActivateProduct()
        {
            return View();
        }

        [Route("admin/product/{productname}/activate")]
        public IActionResult ActivateProduct()
        {
            return View();
        }

        [Route("admin/product/add")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [Route("admin/product/add")]
        [HttpPost]
        public IActionResult AddCategory(int category)
        {
            return View();
        }
    }
}
