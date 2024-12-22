using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service{
    public class AdminDashboardService{
        private CookBookDBContext _context;
        public AdminDashboardService(CookBookDBContext context){
            _context=context;
        }
        public async Task<List<AdminDashboard>> GetAdminDashboardsAsync(){
            return await _context.AdminDashboards.ToListAsync();
        }

        public async Task AddAdminDashboard(AdminDashboard adminDashboard){
            _context.AdminDashboards.Add(adminDashboard);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAdminDashboard(AdminDashboard adminDashboard){
            _context.AdminDashboards.Update(adminDashboard);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdminDashboard(AdminDashboard adminDashboard)
        {
            _context.AdminDashboards.Remove(adminDashboard);
            await _context.SaveChangesAsync();
        }

    }
}