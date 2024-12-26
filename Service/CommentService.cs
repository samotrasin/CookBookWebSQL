using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;


namespace CookBookWebSQL.Service
{
    public class CommentService
    {
        private readonly CookBookDBContext _context;

        public CommentService(CookBookDBContext context)
        {
            _context = context;
        }

        public async Task AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetCommentsByRecipeId(int recipeId)
        {
            return await _context.Comments.Where(c => c.RecipeId == recipeId).ToListAsync();
        }
    }
}
