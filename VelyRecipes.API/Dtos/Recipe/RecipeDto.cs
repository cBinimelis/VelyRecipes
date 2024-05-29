using VelyRecipes.Dtos.Ingredient;
using VelyRecipes.Dtos.Step;

namespace VelyRecipes.Dtos.Recipe
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? Calories { get; set; }
        public int? CookTime { get; set; }

        public List<IngredientDto> Ingredients { get; set; } = new();
        public List<StepDto> Steps { get; set; } = new();
    }
}
