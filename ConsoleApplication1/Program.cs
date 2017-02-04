using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finale.BLL.Repository.EntityRepository;
using Finale.DAL.ORM.Entity;
using Finale.DAL.ORM.Context;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository department = new DepartmentRepository();

            department.Activate(1);

            List<Department> list = department.GetActiveByCondition(x => x.Name == "Anime");

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ID.ToString());
            }

            Console.WriteLine("Done");
            Console.Read();

        }
    }
}
