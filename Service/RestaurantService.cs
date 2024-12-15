using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;
namespace CookBookWebSQL.Service{
    public class RestaurantService{
        private CookBookDBContext _context;
        public RestaurantService(CookBookDBContext context){
            _context=context;
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