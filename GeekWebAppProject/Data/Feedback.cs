using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class Feedback
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 100)]
        public string Text { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 20)]
        public string ClientFullName { get; set; }
        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 40)]
        public string ClientJob { get; set; }
    }
}