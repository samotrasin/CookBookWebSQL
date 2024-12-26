using System.ComponentModel.DataAnnotations;
namespace CookBookWebSQL.Models{

public partial class Restaurant
{
    [Required]
    public string Address { get; set; } = "";
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? GoogleMap {get; set;} = "";  
}
}