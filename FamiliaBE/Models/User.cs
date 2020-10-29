using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamiliaBE.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        public Boolean Gender { get; set; }
        [Required]
        public string Role { get; set; }

    }
}