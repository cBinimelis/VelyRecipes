using System;
using System.Collections.Generic;

namespace VelyRecipes.Models;

public partial class RecipeIngredient
{
    public int IdRecipeIngredient { get; set; }

    public int IdRecipe { get; set; }

    public int IdIngredient { get; set; }

    public string Quantity { get; set; } = null!;

    public virtual Ingredient IdIngredientNavigation { get; set; } = null!;

    public virtual Recipe IdRecipeNavigation { get; set; } = null!;
}
