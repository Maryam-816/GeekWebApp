﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekWebAppProject.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string ImagePath { get; set; }
    }
}