using System;
using System.Collections.Generic;

namespace VelyRecipes.Models;

public partial class Step
{
    public int IdStep { get; set; }

    public int StepNumber { get; set; }

    public string Description { get; set; } = null!;

    public int? IdRecipe { get; set; }

    public virtual Recipe? IdRecipeNavigation { get; set; }
}
