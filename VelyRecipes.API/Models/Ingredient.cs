using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelyRecipes.Library.Models
{
    public class Ingredient
    {
        [Key]
        public int IdIngredient { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string? Unit { get; set; }
    }
}
