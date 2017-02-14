using Finale.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Areas.User.model
{
    public class ItemListVM
    {
        public List<Item> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
}