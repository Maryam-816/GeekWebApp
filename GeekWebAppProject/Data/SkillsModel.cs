using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Data
{
    public class SkillsModel
    {
        public int Id { get; set; }
        [Required]
        public int Procent { get; set; }
        [Required]
        public string Language { get; set; }

    }
}