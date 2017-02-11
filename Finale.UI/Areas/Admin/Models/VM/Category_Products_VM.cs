using Finale.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Areas.Admin.Models.VM
{
    public class Category_Products_VM
    {
        public List<CategoryDTO> Categories { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}