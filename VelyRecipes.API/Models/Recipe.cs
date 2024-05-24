using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelyRecipes.Library.Models;

namespace VelyRecipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int CookTime { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new();
        public List<Step> Steps { get; set; } = new();
    }
}
