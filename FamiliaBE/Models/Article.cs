using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamiliaBE.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubTitle { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public DateTime Current_Time { get; set; }
        [Required]
        public Boolean Headlines { get; set; }
        [Required]
        public string Slideshow { get; set; }

    }
}