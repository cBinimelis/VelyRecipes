using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VelyRecipes.Models;

namespace VelyRecipes.Data;

public partial class RecipesContext : DbContext
{
    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public virtual DbSet<Step> Steps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.IdIngredient);

            entity.ToTable("Ingredient");

            entity.Property(e => e.Name).HasColumnType("INTEGER");
            entity.Property(e => e.Unit).HasDefaultValue("GR");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.IdRecipe);

            entity.ToTable("Recipe");

            entity.Property(e => e.Calories).HasDefaultValue(0);
            entity.Property(e => e.CookTime).HasDefaultValue(10);
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(e => e.IdRecipeIngredient);

            entity.ToTable("RecipeIngredient");

            entity.HasOne(d => d.IdIngredientNavigation).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.IdIngredient)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.IdRecipeNavigation).WithMany(p => p.RecipeIngredients)
                .HasForeignKey(d => d.IdRecipe)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Step>(entity =>
        {
            entity.HasKey(e => e.IdStep);

            entity.ToTable("Step");

            entity.HasOne(d => d.IdRecipeNavigation).WithMany(p => p.Steps).HasForeignKey(d => d.IdRecipe);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
