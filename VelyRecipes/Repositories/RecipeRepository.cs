using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VelyRecipes.Interfaces;
using VelyRecipes.Library.Models;
using VelyRecipes.Models;

namespace VelyRecipes.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipesContext _dbContext;

        public RecipeRepository(RecipesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Recipe> CreateAsync(Recipe recipeModel)
        {
            await _dbContext.Recipes.AddAsync(recipeModel);
            await _dbContext.SaveChangesAsync();
            return recipeModel;
        }

        public async Task<Recipe> DeleteAsync(int id)
        {
            var recipeModel = await _dbContext.Recipes.FirstOrDefaultAsync(x => x.Id == id);
            if (recipeModel == null)
            {
                return null;
            }
            _dbContext.Recipes.Remove(recipeModel);
            await _dbContext.SaveChangesAsync();
            return recipeModel;
        }

        public async Task<List<Recipe>> GetAllAsync()
        {
            return await _dbContext.Recipes.Include(i => i.Ingredients).ToListAsync();
        }

        public async Task<Recipe?> GetByIdAsync(int id)
        {
            return await _dbContext.Recipes.FindAsync(id);
        }

        public Task<Recipe> UpdateAsync(int id, Recipe recipeModel)
        {
            throw new NotImplementedException();
        }
    }
}
