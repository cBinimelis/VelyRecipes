using VelyRecipes.Dtos.Step;
using VelyRecipes.Models;

namespace VelyRecipes.API.Mappers
{
    public static class StepMapper
    {
        public static StepDto ToStepDto(this Step stepModel)
        {
            return new StepDto
            {
                IdStep = stepModel.IdStep,
                StepNumber = stepModel.StepNumber,
                Description = stepModel.Description,
                IdRecipe = stepModel.IdRecipe,

            };
        }
    }
}
