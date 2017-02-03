using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finale.BLL.Repository;
using Finale.DAL.ORM.Entity;

namespace Bll_Tes
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository service = new DepartmentRepository();

            Department departmentlist = service.GetSingleById(1);

            Console.WriteLine(departmentlist.DepartmentName);
            Console.Read();
           
        }
    }
}
