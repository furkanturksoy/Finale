using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Item : Base
    {
        public override int ID
        {
            get
            {
                return base.ID;
            }

            set
            {
                base.ID = value;
            }
        }

        //Shopping Cart Navigation
        [ForeignKey("ShoppingCart")]
        public int ShoppingCartID { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        // Product Navigation

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }



    }
}
