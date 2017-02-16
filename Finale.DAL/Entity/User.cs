using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale.DAL.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserDetail UserDetails { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
