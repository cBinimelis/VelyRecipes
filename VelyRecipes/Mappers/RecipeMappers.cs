using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VelyRecipes.Dtos.Recipe;
using VelyRecipes.Models;

namespace VelyRecipes.Mappers
{
    public static class RecipeMappers
    {
        public static RecipeDto ToRecipeDto(this Recipe recipe){
            return new RecipeDto
            {
                Id = recipe.Id,
                Name = recipe.Name,
                ShortDescription = recipe.ShortDescription,
                Calories = recipe.Calories,
                CookTime = recipe.CookTime,
            };
        }

        public static Recipe ToRecipeFromCreateDTO(this CreateRecipeRequestDto recipeDto){
            return new Recipe
            {
                Name = recipeDto.Name,
                ShortDescription = recipeDto.ShortDescription,
                Calories = recipeDto.Calories,
                CookTime = recipeDto.CookTime,
            };
        }
    }
}