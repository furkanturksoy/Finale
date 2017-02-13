using Finale.DAL.ORM.Context;
using Finale.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Finale.BLL.Repository.BaseRepository
{
    public class Base<T> where T : Base
    {
        protected ProjectContext db;
        protected DbSet<T> table;

        public Base()
        {
            db = new ProjectContext();
            table = db.Set<T>();
        }

        #region Crud
        //Tested
        public void Add(T Entity)
        {
            table.Add(Entity);
            Save();
        }

        //Tested
        public void Disable(int Id)
        {
            table.FirstOrDefault(x => x.ID == Id).isActive = false;
            Save();
        }

        //Tested
        public void Activate(int Id)
        {
            table.FirstOrDefault(x => x.ID == Id).isActive = true;
            Save();
        }
        public virtual void Update()
        {
            return;
        }
        #endregion

        #region List
        public List<T> GetAll()
        {
            return table.ToList();
        }

        //Tested
        public List<T> GetActive()
        {
            return table.Where(x => x.isActive == true).ToList();


        }

        //Tested
        public List<T> GetDisabled()
        {
            return table.Where(x => x.isActive == false).ToList();
        }

        //Tested
        public List<T> GetActiveByCondition(Expression<Func<T, bool>> lambda)
        {
            return table.Where(x => x.isActive == true).Where(lambda).ToList();
        }
        //Tested
        public List<T> GetDisabledByCondition(Expression<Func<T, bool>> lambda)
        {
            return table.Where(x => x.isActive == false).Where(lambda).ToList();
        }
        
        // Take 10
        #endregion

        #region Single
        //Tested
        public T GetOneByCondition(Expression<Func<T, bool>> lambda)
        {
            return table.FirstOrDefault(lambda);
        }

        //Tested
        public T GetOneByID(int ID)
        {
            return table.FirstOrDefault(x => x.ID == ID);
        }

        #endregion

        #region Misc
         public void Save()
        {
            db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> lambda)
        {
            return table.Any(lambda);
        }
        #endregion

    }
}
