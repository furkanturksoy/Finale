using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.Entity
{
    public class ShoppingCart
    {
        [Key]
        [ForeignKey("User")]
        public int ShoppingCartID { get; set; }
        public User User { get; set; }



        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }



    }
}
