namespace CookBookWebSQL.Models
{
    public class Cuisine
    {
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public List<Recipe> Recipes { get; set; }= new List<Recipe>();
    }
}