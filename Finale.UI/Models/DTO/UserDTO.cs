using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finale.UI.Models.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(25)]
        public string Lastname { get; set; }

        [Required]
        public string Address { get; set; }

    }
}