using System.Collections.Generic;
using System.Threading.Tasks;
using CookBookWebSQL;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantManagementWebSQL.Service
{
    public class RestaurantService
    {
        private readonly CookBookDBContext _context;

        public RestaurantService(CookBookDBContext context)
        {
            _context = context;
        }

        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task AddRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRestaurant(Restaurant restaurant)
        {
            _context.Entry(restaurant).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
        }
    }
}
