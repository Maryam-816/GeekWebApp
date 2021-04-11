using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Text { get; set; }
        public string ClientFullName { get; set; }
        public string ClientJob { get; set; }
    }
}