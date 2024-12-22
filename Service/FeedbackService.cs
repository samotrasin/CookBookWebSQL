using CookBookWebSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CookBookWebSQL.Service{

    public class FeedbackService{
        private CookBookDBContext _context;
        public FeedbackService(CookBookDBContext context){
            _context=context;
        }
        public async Task<Feedback> AddFeedback(Feedback feedback){
            await _context.Feedbacks.AddAsync(feedback);
            await _context.SaveChangesAsync();
            return feedback;
        }
    }
}