using Finale.BLL.Service;
using Finale.DAL.ORM.Entity;
using Finale.UI.Areas.Admin.Models;
using Finale.UI.Areas.Admin.Models.DTO;
using Finale.UI.Areas.Admin.Models.VM;
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

        [Route("admin/products/list/{categoryname?}")]
        public ActionResult Products(string categoryname)
        {
        
            if(categoryname == null) { 
            var model = service.CategoryService.GetAll().Select(x => new CategoryDTO()
            {
                Name = x.Name
            }).ToList();
                Category_Products_VM vm = new Category_Products_VM();
                vm.Categories = model;

                vm.Products = null;
                return View("~/Areas/Admin/Views/Product/Products.cshtml", vm);
            }else

            {
                var model = service.CategoryService.GetAll().Select(x => new CategoryDTO()
                {
                    Name = x.Name
                }).ToList();

                var productmodel = service.ProductService.GetAll().Where(x => x.Category.Name == categoryname).Select(x => new ProductDTO()

                {
                    Name = x.Name,
                    Description = x.Description

                }).ToList();
                Category_Products_VM vm = new Category_Products_VM();
                vm.Categories = model;
                vm.Products = productmodel;
                return View("~/Areas/Admin/Views/Product/Products.cshtml", vm);


            }








        }

        [Route("admin/products/new/")]
        public ActionResult NewProduct(string categoryname)
        {
            var model = service.CategoryService.GetAll().Select(x => new CategoryDTO()
            {
                Name = x.Name
            }).ToList();

            

            Category_Products_VM vm = new Category_Products_VM();
            vm.Categories = model;
            vm.Products = null;

            return View("~/Areas/Admin/Views/Product/addProduct.cshtml", vm);
        }

        [HttpPost]
        [Route("admin/products/new")]
        public ActionResult NewProduct(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                Product prod = new Product();
                prod.isActive = true;
                prod.Name = product.Name;
                prod.Price = product.Price;
                prod.Description = product.Description;
                prod.CategoryID = service.CategoryService.GetOneByCondition(x => x.Name == product.Name).ID;

                service.ProductService.Add(prod);
            }
            return Redirect("/admin/products/list");
        }


    }
}