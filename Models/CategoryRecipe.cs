using System.ComponentModel.DataAnnotations;

namespace CookBookWebSQL.Models
{
    public class CategoryRecipe
    {
        [Key]
        public int RecipeId { get; set; }
        [Key]
        public int CategoryId { get; set; }

        public Recipe? Recipe { get; set; } 
        public Category? Category { get; set; }
    }
}
