using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finale.UI.Areas.Admin.Models
{
    public class CategoryDTO
    {
        [Required(ErrorMessage = "you can not add a category without name")]
        public string Name { get; set; }
        [MaxLength(255, ErrorMessage = "you can not set description more than 255 characters")]
        public string Description { get; set; }

    }
}