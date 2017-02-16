using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.Entity
{
    public class Order
    {

        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public bool isActive { get; set; }

        [ForeignKey("ShoppingCart")]
        public int ShoppingCartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        

        public List<Product> Products { get; set; }
    }
}
