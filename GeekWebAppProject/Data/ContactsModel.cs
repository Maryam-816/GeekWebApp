using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class ContactsModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Your Email isn't valid")]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Subject { get; set; }
        [Required]
        [StringLength(maximumLength: 1000, MinimumLength = 2)]
        public string Text { get; set; }
    }
}