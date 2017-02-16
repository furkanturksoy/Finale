using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public bool isActive { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public List<Order> Order { get; set; }
        public List<ShoppingCart> ShoppingCart { get; set; }
    }
}
