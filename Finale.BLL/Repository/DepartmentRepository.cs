using Finale.DAL.ORM.Context;
using Finale.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Finale.BLL.Repository
{
    
    public class DepartmentRepository
    {
        protected ProjectContext db;
        protected DbSet<Department> table;

        public DepartmentRepository()
        {
            db = new ProjectContext();
            table = db.Set<Department>();
            
        }


        #region Crud

        //Tested
        public void Add(Department Entity)
        {
            table.Add(Entity);
            db.SaveChanges();
        }

        //Tested
        public void Disable(int id)
        {
            Department entity = table.FirstOrDefault(x => x.DepartmentID == id);
            entity.isActive = false;
            db.SaveChanges();
        }

        //Tested
        public void Activate(int id)
        {
            Department entity = table.FirstOrDefault(x => x.DepartmentID == id);
            entity.isActive = true;
            db.SaveChanges();
        }

        //Not Tested Need Changes
        public void Update(Department Entity)
        {
            Department entity = table.FirstOrDefault(x => x.DepartmentID == Entity.DepartmentID);

            entity.DepartmentName = Entity.DepartmentName;
        }

        #endregion

        #region List
        //Tested
        public List<Department> GetList()
        {
            return table.ToList();
        }
        //Tested
        public List<Department> GetActiveListByCondition(Expression<Func<Department, bool>> lambda)
        {
            return table.Where(x => x.isActive == true).Where(lambda).ToList();
        }
        //Tested
        public List<Department> GetNotActiveListByCondition(Expression<Func<Department, bool>> lambda)
        {
            return table.Where(x => x.isActive == false).Where(lambda).ToList();
        }
        #endregion

        #region GetSingle

        //Tested
        public Department GetSingleById(int id)
        {
            return table.FirstOrDefault(x => x.DepartmentID == id);
        }
        //Tested
        public Department GetSingleByName(string name)
        {
            return table.FirstOrDefault(x => x.DepartmentName == name);
        }

        //Tested
        public Department GetSingleByLambda(Expression<Func<Department, bool>> lambda)
        {
            return table.FirstOrDefault(lambda);
        }
        #endregion





    }
}
