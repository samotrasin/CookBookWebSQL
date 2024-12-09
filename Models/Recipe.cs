namespace CookBookWebSQL.Models
{
    public class Recipe
    {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Instructions { get; set; }="";
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    public List<RecipeImage> Images { get; set; }= new List<RecipeImage>();
    public List<Category> Categories { get; set; }= new List<Category>();
    }
    // add
}