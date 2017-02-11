using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Areas.Admin.Models.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryName { get; set; }
        public decimal Price { get; set; }

    }
}