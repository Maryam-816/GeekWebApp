using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class Menu
    {
        public int Id { get; set; }
        public string LogoImagePath { get; set; }
        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 30)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string Text { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string NavName { get; set; }
        
        
    }
}