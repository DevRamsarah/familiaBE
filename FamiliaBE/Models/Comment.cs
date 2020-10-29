using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamiliaBE.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int PostID { get; set; }
        [Required]
        public string CommentDes { get; set; }
        [Required]
        public DateTime Current_Time { get; set; }
        [Required]
        public Boolean Trend { get; set; }
        [Required]
        public Boolean Anonyma { get; set; }




    }
}