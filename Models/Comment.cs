namespace CookBookWebSQL.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public int Rating { get; set; }
        public string? Text { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
