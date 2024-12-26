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

        public async Task<List<RestaurantDetail>> GetRestaurantsAsync()
        {
            return await _context.RestaurantDetails.ToListAsync();
        }

        public async Task AddRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.RestaurantDetails.Add(restaurantDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.Entry(restaurantDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.RestaurantDetails.Remove(restaurantDetail);
            await _context.SaveChangesAsync();
        }
    }
}
