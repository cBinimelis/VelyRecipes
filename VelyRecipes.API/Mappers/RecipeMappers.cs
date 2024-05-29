using VelyRecipes.API.Mappers;
using VelyRecipes.Dtos.Recipe;
using VelyRecipes.Models;

namespace VelyRecipes.Mappers
{
    public static class RecipeMappers
    {
        public static RecipeDto ToRecipeDto(this Recipe recipe)
        {
            return new RecipeDto
            {
                Id = recipe.IdRecipe,
                Name = recipe.Name,
                Description = recipe.Description,
                Calories = recipe.Calories,
                CookTime = recipe.CookTime,
                Steps = recipe.Steps.Select(s => s.ToStepDto()).ToList(),
            };
        }

        public static Recipe ToRecipeFromCreateDTO(this CreateRecipeRequestDto recipeDto)
        {
            return new Recipe
            {
                Name = recipeDto.Name,
                Description = recipeDto.ShortDescription,
                Calories = recipeDto.Calories,
                CookTime = recipeDto.CookTime,
            };
        }
    }
}
