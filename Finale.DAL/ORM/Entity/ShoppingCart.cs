using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    class ShoppingCart
    {
        
        [Key()]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; } // both primary and foreign key child of customer

        public virtual List<Order> OrdersFromCart { get; set; } // navigation for orders

        //item navigaton
        public virtual List<Item> Items { get; set; }

        private decimal _totalPrice;

        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                foreach (var item in Items)
                {
                    _totalPrice += item.Product.Price;
                }
            }
                

            }
        }

    }
