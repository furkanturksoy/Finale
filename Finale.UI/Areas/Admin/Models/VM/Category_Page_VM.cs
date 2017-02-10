using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Areas.Admin.Models.VM
{
    public class Category_Page_VM
    {
        public List<CategoryDTO> Category { get; set; }
        public int page { get; set; }
    }
}