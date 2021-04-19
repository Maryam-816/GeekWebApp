using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 55, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 15, MinimumLength = 5)]
        public string Password { get; set; }

    }
}