using System;
using System.Collections.Generic;

namespace VelyRecipes.Models;

public partial class Ingredient
{
    public int IdIngredient { get; set; }

    public string Name { get; set; } = null!;

    public string? Unit { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
