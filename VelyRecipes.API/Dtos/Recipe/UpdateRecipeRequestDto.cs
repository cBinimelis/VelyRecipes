using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelyRecipes.Dtos.Recipe
{
    public class UpdateRecipeRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public int Calories { get; set; }
        public int CookTime { get; set; }
    }
}
