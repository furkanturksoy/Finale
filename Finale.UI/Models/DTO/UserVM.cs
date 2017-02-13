using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Models.DTO
{
    public class UserVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}