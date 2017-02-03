﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    class CustomerDetails
    {
        [Key()]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
