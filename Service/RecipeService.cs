using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service
{
    public class RecipeService
    {
        private CookBookDBContext _context;
        public RecipeService(CookBookDBContext context){
            _context=context;
        }

        // Optimized method for fetching recipes for dropdown
        public async Task<List<Recipe>> GetRecipesForDropdownAsync()
        {
            return await _context.Recipes
                                 .Select(r => new Recipe
                                 {
                                     Id = r.Id,
                                     Name = r.Name
                                 })
                                 .ToListAsync();
        }


        public async Task<List<Recipe>> GetRecipesAsync(){
            return await _context.Recipes
                                    .Include(r => r.Images)
                                    .Include(r => r.CategoryRecipe)
                                        .ThenInclude(cr => cr.Category) // Include the Category entity
                                    .ToListAsync();
        }
        
        public async Task AddRecipe(Recipe recipe)
        {
            var categoryRecipes = new List<CategoryRecipe>();

            foreach (var categoryRecipe in recipe.CategoryRecipe)
            {
                var category = await _context.Categories.FindAsync(categoryRecipe.CategoryId);
                if (category != null)
                {
                    categoryRecipes.Add(new CategoryRecipe{ Recipe = recipe, Category = category });
                }
            }

            recipe.CategoryRecipe = categoryRecipes;

            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRecipe(int id, Recipe recipe)
        {
            try
            {
                var existingRecipe = await _context.Recipes
                                                    .Include(r => r.CategoryRecipe)
                                                    .ThenInclude(cr => cr.Category)
                                                    .FirstOrDefaultAsync(r => r.Id == recipe.Id);
                if (existingRecipe != null)
                {
                    existingRecipe.Name = recipe.Name;
                    existingRecipe.Instructions = recipe.Instructions;
                    existingRecipe.UpdatedDate = DateTime.Now;
                    existingRecipe.Images = recipe.Images;

                    // Clear existing categories
                    existingRecipe.CategoryRecipe.Clear();

                    // Update categories
                    var categoryRecipes = new List<CategoryRecipe>();
                    foreach (var categoryRecipe in recipe.CategoryRecipe)
                    {
                        var category = await _context.Categories.FindAsync(categoryRecipe.CategoryId);
                        if (category != null)
                        {
                            //var newCategoryRecipe = new CategoryRecipe { Recipe = existingRecipe, Category = category };
                            categoryRecipes.Add(new CategoryRecipe { RecipeId = existingRecipe.Id, CategoryId = category.Id });
                            //categoryRecipes.Add(newCategoryRecipe);
                        }
                        else
                        {
                            Console.WriteLine($"Category with ID {categoryRecipe.CategoryId} not found");
                        }
                    }

                    existingRecipe.CategoryRecipe = categoryRecipes;

                    _context.Recipes.Update(existingRecipe);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Recipe not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the recipe: {ex.Message}");
            }
        }

        public async Task DeleteRecipe(Recipe recipe){
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
        }
    }
}