using Finale.DAL.ORM.Context;
using Finale.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    }
}
