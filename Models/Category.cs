namespace CookBookWebSQL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public List<CategoryRecipe> CategoryRecipes { get; set; } = new List<CategoryRecipe>();
    }
}