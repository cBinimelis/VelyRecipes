﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VelyRecipes.Library.Models;

#nullable disable

namespace VelyRecipes.Library.Migrations
{
    [DbContext(typeof(RecipesContext))]
    partial class RecipesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("VelyRecipes.Library.Models.Ingredient", b =>
                {
                    b.Property<int>("IdIngredient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT");

                    b.HasKey("IdIngredient");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("VelyRecipes.Library.Models.Step", b =>
                {
                    b.Property<int>("IdStep")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdRecipe")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StepNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdStep");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("VelyRecipes.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CookTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
