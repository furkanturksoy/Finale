using Finale.BLL.Service;
using Finale.DAL.ORM.Entity;
using Finale.UI.Areas.User.model;
using Finale.UI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finale.UI.Areas.User.Controllers
{
    public class ShoppingCartController : Controller
    {
        service service = new service();

        [Route("user/panel/shoppingcart")]
        public ActionResult Cart()
        {
            ViewBag.Context = HttpContext;

            ShoppingCart cart = service.ShoppingCartService.GetOneByID(AuthManager.CurrentUserID);
          
            decimal Totalprice = 0;


            try { 
            foreach(var item in cart.Items)
            {
                Totalprice += item.Product.Price;
            }
            }catch
            {

            }




            return View("~/Areas/User/Views/ShoppingCart/Cart.cshtml", Totalprice);
        }

        [Route("user/panel/shoppingcart/itemlist")]
        public ActionResult ItemList()
        {
            List<Item> list = service.ItemService.GetActiveByCondition(x => x.ShoppingCart.Customer.ID == AuthManager.CurrentUserID);
            decimal totalprice = 0;

            foreach(var item in list)
            {
                totalprice += item.Product.Price;
            }

            ItemListVM vm = new ItemListVM();
            vm.Items = list;
            vm.TotalPrice = totalprice;

            return View("~/Areas/User/Views/ShoppingCart/ItemList.cshtml",vm);
        }

        [Route("user/pane/shoppingcart/remove/{itemid}")]
        public ActionResult RemoveItem()
        {
            return View();
        }

        [Route("user/panel/shoppingcart/checkout")]
        public ActionResult CheckOut()
        {
            return View();
        }
    }
}