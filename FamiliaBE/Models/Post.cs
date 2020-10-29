using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamiliaBE.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public string PostDes { get; set; }

        [Required]
        public DateTime Current_Time { get; set; }
        [Required]
        public Boolean Headlines { get; set; }

        public int CategoryID { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}