using Finale.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.Context
{
    public class FinaleContext : DbContext
    {
        public FinaleContext()
        {
            Database.Connection.ConnectionString = @"Server=ASUS-BILGISAYAR; Database=Finale2; Integrated Security=yes;";
        }

        public DbSet<Category> Categorie { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<ShoppingCart> Cart { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
    
    }
}
