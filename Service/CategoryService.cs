using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service
{
    public class CategoryService
    {
        private CookBookDBContext _context;
        public CategoryService(CookBookDBContext context)
        {
            _context=context;
        }
        public async Task<List<Category>> GetCategoriesAsync(){
            return await _context.Categories.ToListAsync();
        }

        public async Task AddCategory(Category category){
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategory(Category category){
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

    }
}