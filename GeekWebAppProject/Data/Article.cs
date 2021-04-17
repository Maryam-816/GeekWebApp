using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:20, MinimumLength =2)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:200, MinimumLength = 100 )]
        public string Text { get; set; }
        public string ImagePath { get; set; }
    }
}