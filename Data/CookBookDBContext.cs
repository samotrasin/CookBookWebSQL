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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Images)
            .WithOne()
            .HasForeignKey("UserId")
            .OnDelete(DeleteBehavior.Cascade); // Enable cascade delete
    }
}

