using Azure.Core.Pipeline;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL;

public class CookBookDBContext : DbContext{
    public CookBookDBContext(DbContextOptions<CookBookDBContext> options) : base(options)
    {
        
    }

    public DbSet<Cuisine> Cuisines{get; set;}
    public DbSet<Category> Categories{get; set;}
    public DbSet<Recipe> Recipes{get; set;}
    public DbSet<RecipeImage> RecipeImages{get; set;}
    public DbSet<User> Users{get;set;}
}