using System.Collections.Generic;
using System.Threading.Tasks;
using CookBookWebSQL;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;
using RestaurantDetail=CookBookWebSQL.Models.Restaurant;

namespace CookBookWebSQL.Service
{
    public class RestaurantDetailService
    {
        private readonly CookBookDBContext _context;

        public RestaurantDetailService(CookBookDBContext context)
        {
            _context = context;
        }

        public async Task<List<RestaurantDetail>> GetRestaurantsAsync()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task AddRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.Restaurants.Add(restaurantDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.Entry(restaurantDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurant(RestaurantDetail restaurantDetail)
        {
            _context.Restaurants.Remove(restaurantDetail);
            await _context.SaveChangesAsync();
        }
    }
}
