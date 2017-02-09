using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Finale.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/category")]
    public class CategoryController : Controller
    {

        [Route("admin/category/page/{id?}")]
        public IActionResult Categories(int id)
        {
            return View();
        }

        [Route("admin/category/{categoryname}")]
        public IActionResult Category(string name)
        {
            return View();
        }
        [Route("admin/category/{categoryname}/update")]
        public IActionResult UpdateCategory()
        {
            return View();
        }

        [Route("admin/category/{categoryname}/deactivate")]
        public IActionResult DeActivateCategory()
        {
            return View();
        }

        [Route("admin/category/{categoryname}/activate")]
        public IActionResult ActivateCategory()
        {
            return View();
        }

        [Route("admin/category/add")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [Route("admin/category/add")]
        [HttpPost]
        public IActionResult AddCategory(int category)
        {
            return View();
        }

    }
}
