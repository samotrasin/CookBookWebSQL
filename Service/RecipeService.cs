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
                                    .Include(rp => rp.Images)
                                    .Include(rp => rp.Categories)
                                    .ToListAsync();
        }
        
        public async Task AddRecipe(Recipe recipe){
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRecipe(Recipe recipe){
            _context.Recipes.Update(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecipe(Recipe recipe){
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();
        }
    }
}