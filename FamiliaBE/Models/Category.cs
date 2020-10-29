using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamiliaBE.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }




    }
}