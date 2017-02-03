using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Order
    {
        [Key()]
        [ForeignKey("Item")]
        public int OrderID { get; set; }


       
        public Item Item { get; set; }

        // Order State will be added later

    }
}
