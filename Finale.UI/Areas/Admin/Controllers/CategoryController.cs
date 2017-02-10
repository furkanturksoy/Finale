using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Finale.BLL.Service;
using Finale.UI.Areas.Admin.Models;
using Finale.UI.Areas.Admin.Models.VM;
using Finale.DAL.ORM.Entity;

namespace Finale.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        service service = new service();

        #region Crud

        //AddCategory
        [Route("admin/categories/new")]
        public ActionResult AddCategory()
        {
            return View("~/Areas/Admin/Views/Category/categoryAdd.cshtml");
        }

        
        [Route("admin/categories/new")]
        [HttpPost]
        public ActionResult AddCategory(CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                service.CategoryService.Add(new DAL.ORM.Entity.Category()
                {
                    Name = category.Name,
                    Description = category.Description,
                    isActive = true,

                });
            }
            return Redirect("/admin/categories/list");
        }

        //CategoryActivate

        [Route("admin/categories/{categoryname}/activate")]
        public ActionResult ActivateCategory(string categoryname)
        {
            Category category = service.CategoryService.GetOneByCondition(x => x.Name == categoryname);
            category.isActive = true;
            service.CategoryService.Save();

            return Redirect("/admin/categories/list");
        }

        //CategoryDeActivate
        [Route("admin/categories/{categoryname}/deactivate")]
        public ActionResult DeactivateCategory(string categoryname)
        {
            Category category = service.CategoryService.GetOneByCondition(x => x.Name == categoryname);
            category.isActive = false;
            service.CategoryService.Save();
            return Redirect("/admin/categories/list");
        }


        //CategoryUpdate
        [Route("admin/categories/{categoryname}/update")]
        public ActionResult UpdateCategory(string categoryname)
        {
            Category category = service.CategoryService.GetOneByCondition(x => x.Name == categoryname);

            return View("~/Areas/Admin/Views/Category/categoryUpdate.cshtml", category);
        }
        [Route("admin/categories/{categoryname}/update")]
        [HttpPost]
        public ActionResult UpdateCategoryPost(CategoryDTO category, string categoryname)
        {
            Category updated = service.CategoryService.GetOneByCondition(x => x.Name == categoryname);
            updated.Name = category.Name;
            updated.Description = category.Description;
            service.CategoryService.Save();
            return Redirect("/admin/categories/list");
        }



        #endregion

        #region List
        [Route("admin/categories/list/")]
        public ActionResult Categories()
        {
            var model = service.CategoryService.GetAll().Select(x => new CategoryDTO
            {
                Name = x.Name,
                Description = x.Description

            }).ToList();

            return View("~/Areas/Admin/Views/Category/Categories.cshtml", model);
        }

        [Route("admin/categories/info/{categoryname}")]
        public ActionResult Category(string categoryname)
        {
            var category = service.CategoryService.GetOneByCondition(x => x.Name == categoryname);

            CategoryDTO model = new CategoryDTO();

            model.Name = category.Name;
            model.Description = category.Description;

            return View(model);
        }
        #endregion



       
    }
}