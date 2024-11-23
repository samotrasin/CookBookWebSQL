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
        public async Task<List<Recipe>> GetRecipesAsync(){
            return await _context.Recipes.Include(rp => rp.Images).ToListAsync();
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