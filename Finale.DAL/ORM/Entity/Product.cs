using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Product : Base
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
        public override string Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
            }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //UnitsInStock will be adding later
        //UnitsSold will be adding later

        //Category Navigation

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        // Order Navigation one to one


        public virtual List<Review> Reviews { get; set; }

        // item Navigation

        public virtual List<Item> Items { get; set; }

    }
}
