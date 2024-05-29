using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VelyRecipes.Dtos.Step
{
    public class StepDto {
        public int IdStep { get; set; }

        public int StepNumber { get; set; }

        public string Description { get; set; } = null!;

        public int? IdRecipe { get; set; }
    }
}
