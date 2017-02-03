using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    class Item
    {
        [Key()]
        public int ItemID { get; set; }

        //Shopping Cart Navigation
        [ForeignKey("ShoppingCart")]
        public int ShoppingCartID { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

        // Order Navigation
        public virtual Order Order { get; set; }

        // Product Navigation

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }



    }
}
