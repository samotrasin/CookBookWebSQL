using Azure.Core.Pipeline;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL;

public class CookBookDBContext : DbContext{
    public CookBookDBContext(DbContextOptions<CookBookDBContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Cuisine> Cuisines{get; set;}
    public DbSet<Category> Categories{get; set;}
    public DbSet<Recipe> Recipes{get; set;}
    public DbSet<RecipeImage> RecipeImages{get; set;}
    public DbSet<User>Users{get;set;}
    public DbSet<UserImage>UserImages{get;set;}
    public DbSet<Ingredient>Ingredients { get; set; }
    public DbSet<IngredientImage>IngredientImages { get; set; }
    public DbSet<CategoryRecipe> CategoryRecipes { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<AdminDashboard> AdminDashboards { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //configure user-userimage relationship
        modelBuilder.Entity<User>()
            .HasMany(u => u.Images)
            .WithOne()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade); // Enable cascade delete

        //configure Recipe-Category many-to-many relationship
        modelBuilder.Entity<CategoryRecipe>()
            .HasKey(cr => new { cr.RecipeId, cr.CategoryId });

        modelBuilder.Entity<CategoryRecipe>()
            .HasOne(cr => cr.Recipe)
            .WithMany(r => r.CategoryRecipe)
            .HasForeignKey(cr => cr.RecipeId);

        modelBuilder.Entity<CategoryRecipe>()
            .HasOne(cr => cr.Category)
            .WithMany(c => c.CategoryRecipes)
            .HasForeignKey(cr => cr.CategoryId);
    }
}

