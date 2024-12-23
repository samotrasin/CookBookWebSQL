using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;
namespace CookBookWebSQL.Service{
    public class RestaurantService{
        private CookBookDBContext _context;
        public RestaurantService(CookBookDBContext context){
            _context=context;
        }
        public async Task<Restaurant> GetRestaurantByIdAsync(int id)
        {
            var restaurant = await _context.Restaurants
                                    //.Include(r => r.Images) // Ensure images are included
                                    .FirstOrDefaultAsync(r => r.Id == id);
            return restaurant;
        }
         public async Task<List<Restaurant>> GetRestaurantAsync(){
            return await _context.Restaurants
                                    // .Include(r => r.Images)
                                    //.Include(r => r.RestaurantMenus)
                                    .ToListAsync();
        }
        public async Task AddRestaurant(Restaurant restaurant){
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateRestaurant(Restaurant restaurant){
            _context.Restaurants.Update(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurant(Restaurant restaurant){
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
        }
    }
}