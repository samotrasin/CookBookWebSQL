using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service{

    public class CuisineService{
        private CookBookDBContext _context;
        public CuisineService(CookBookDBContext context){
            _context=context;
        }

        public async Task<List<Cuisine>> GetCuisinesAsync(){
            return await _context.Cuisines.ToListAsync();
        }

        public async Task<Cuisine> AddCuisine(Cuisine cuisine){
            await _context.Cuisines.AddAsync(cuisine);
            await _context.SaveChangesAsync();
            return cuisine;
        }

        public async Task UpdateCuisine(Cuisine cuisine){
            _context.Cuisines.Update(cuisine);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteCuisine(Cuisine cuisine){
            _context.Cuisines.Remove(cuisine);
            await _context.SaveChangesAsync();
        }
    }
}
