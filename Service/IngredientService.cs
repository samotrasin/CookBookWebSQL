using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;
namespace CookBookWebSQL.Service
{


    public class IngredientService
    {
        private CookBookDBContext _context;

        public IngredientService(CookBookDBContext context)
        {
            _context = context;
        }
        public async Task<List<Ingredient>> GetIngredientForDropdownAsync()
        {
            return await _context.Ingredients
                                 .Select(r => new Ingredient
                                 {
                                     Id = r.Id,
                                     Name = r.Name
                                 })
                                 .ToListAsync();
        }




        public async Task<List<Ingredient>> GetIngredientsAsync()
        {
            return await _context.Ingredients
                                            .Include(ing => ing.Images).ToListAsync();
        }

        public async Task AddIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();

            // hi 
        }

        public async Task UpdateIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Update(ingredient);
            await _context.SaveChangesAsync();
            //ADDD
        }

        public async Task DeleteIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
            await _context.SaveChangesAsync();
        }
    }


}