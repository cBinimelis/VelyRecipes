﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelyRecipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int Calories { get; set; }
        public int CookTime { get; set; }
    }
}
