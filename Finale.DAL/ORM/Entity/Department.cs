using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Department : Base
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


        // Category Navigation
        public virtual List<Category> Categories { get; set; }



    }
}
