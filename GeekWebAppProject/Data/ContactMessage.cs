using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class ContactMessage
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email isn't given")]
        [EmailAddress(ErrorMessage = "Your Email isn't valid")]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 2)]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message isn't given")]
        [StringLength(maximumLength: 1000, MinimumLength = 1)]
        public string Text { get; set; }
    }
}