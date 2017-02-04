using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Category : Base
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


        

        //Department Navigation
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        // Product navigation

        public virtual List<Product> Products { get; set; }

    }
}
