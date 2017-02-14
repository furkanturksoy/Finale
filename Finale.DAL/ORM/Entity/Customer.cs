﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Customer : Base
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

        public string UserName { get; set; }
        public string Password { get; set; }
        
        public virtual CustomerDetails CustomerDetails { get; set; }

        //ShoppingCart Navigation
        public virtual ShoppingCart ShoppingCart { get; set; }

        // Orders Navigation



    }

    
}
