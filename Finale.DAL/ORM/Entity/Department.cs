using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.ORM.Entity
{
    public class Department
    {

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }


        // Category Navigation
        public virtual List<Category> Categories { get; set; }


        public bool isActive { get; set; }
    }
}
