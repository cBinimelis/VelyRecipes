using Microsoft.AspNetCore.Mvc;
using VelyRecipes.Dtos.Recipe;
using VelyRecipes.Interfaces;
using VelyRecipes.Mappers;

namespace VelyRecipes.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipesController : ControllerBase
{
    private readonly IRecipeRepository _recipeRepo;

    public RecipesController(IRecipeRepository recipeRepo)
    {
        _recipeRepo = recipeRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var recipes = await _recipeRepo.GetAllAsync();
        var recipesDto = recipes.Select(s => s.ToRecipeDto());
        return Ok(recipesDto);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateRecipeRequestDto recipeDto)
    {
        var recipeModel = recipeDto.ToRecipeFromCreateDTO();
        await _recipeRepo.CreateAsync(recipeModel);
        return Ok(recipeModel);
        /*
        return CreatedAtAction(
            nameof()
        )
        */
    }
}
