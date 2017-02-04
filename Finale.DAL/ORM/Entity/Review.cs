using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Review : Base
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

        public string ReviewContent { get; set; }

        //Customer Navigation
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        //Produc Navigation
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
