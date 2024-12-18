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
    public DbSet<Feedback>Feedbacks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(u => u.Images)
        .WithOne(ui => ui.User)
        .HasForeignKey(ui => ui.UserId);
    }
}

