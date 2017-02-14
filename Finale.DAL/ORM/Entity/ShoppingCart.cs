using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class ShoppingCart : Base
    {

        [Key()]
        [ForeignKey("Customer")]
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
        public virtual Customer Customer { get; set; } // both primary and foreign key child of customer


        //item navigaton
        public virtual List<Item> Items { get; set; }

       
                

            
        }

    }
