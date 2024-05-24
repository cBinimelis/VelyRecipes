using VelyRecipes.Models;

namespace VelyRecipes.Interfaces
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetAllAsync();
        Task<Recipe> GetByIdAsync(int id);
        Task<Recipe> CreateAsync(Recipe recipeModel);
        Task<Recipe> DeleteAsync(int id);
        Task<Recipe> UpdateAsync(int id, Recipe recipeModel);
    }
}
