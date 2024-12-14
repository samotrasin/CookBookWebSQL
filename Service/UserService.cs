using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;


namespace CookBookWebSQL.Service
{
    public class UserService
    {
        private CookBookDBContext _context;

        public UserService(CookBookDBContext context)
        {
            _context = context;
        }

        public async Task<User?> LoginAsync(string userEmail,string userPassword){
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == userEmail && u.Password == userPassword);
        }

        public async Task<User?> RegisterAsync(User user){
            if(await _context.Users.AnyAsync( u => u.Email == user.Email))
            throw new InvalidOperationException("Email already exists.");
            if(await _context.Users.AnyAsync( u=> u.UserName == user.UserName))
            throw new InvalidOperationException("UserName already exists.");

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;

        }


        public async Task<User> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> UpdateUserAsync(User user){
            var existsUser = await _context.Users.FindAsync(user.Id);
            if(existsUser == null) return null;

            existsUser.Id = user.Id;
            existsUser.UserName = user.UserName;
            existsUser.Email = user.Email;
            existsUser.Password = user.Password;
            existsUser.Roles = user.Roles;
            existsUser.IsEmailConfirmed = user.IsEmailConfirmed;
            existsUser.IsPhoneNumberConfirmed = user.IsPhoneNumberConfirmed;

            await _context.SaveChangesAsync();
            return existsUser;
        }

        public async Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
