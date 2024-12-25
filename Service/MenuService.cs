using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service
{
    public class MenuService
    {
        private CookBookDBContext _context;
        public MenuService(CookBookDBContext context){
            _context=context;
        }

        // Optimized method for fetching recipes for dropdown
        public async Task<List<RestaurantMenu>> GetMenuForDropdownAsync()
        {
            return await _context.RestaurantMenus
                                 .Select(r => new RestaurantMenu
                                 {
                                     Id = r.Id,
                                     MenuName = r.MenuName
                                 })
                                 .ToListAsync();
        }


        public async Task<List<RestaurantMenu>> GetMenuAsync(){
            return await _context.RestaurantMenus
                                    .Include(rp => rp.MenuImages)
                                    .Include(rp => rp.Restaurants)
                                    .ToListAsync();
        }
        // public async Task AddMenu(RestaurantMenu menu){
        //     _context.RestaurantMenus.Add(menu);
        //     await _context.SaveChangesAsync();
        // }
        public async Task<RestaurantMenu> AddMenuAsync(RestaurantMenu menu)
        {
            _context.RestaurantMenus.Add(menu);
            await _context.SaveChangesAsync();
            return menu;
        }
        public async Task UpdateMenu(RestaurantMenu menu){
            _context.RestaurantMenus.Update(menu);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteMenu(RestaurantMenu menu){
            _context.RestaurantMenus.Remove(menu);
            await _context.SaveChangesAsync();
        }
    }
}