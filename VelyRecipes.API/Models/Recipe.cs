using System;
using System.Collections.Generic;

namespace VelyRecipes.Models;

public partial class Recipe
{
    public int IdRecipe { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int? Calories { get; set; }

    public int? CookTime { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();
}
