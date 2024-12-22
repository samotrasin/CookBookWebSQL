using System.ComponentModel.DataAnnotations;

public class Restaurant
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = "";
    [Required]
    public string Address { get; set; } = "";
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Description { get; set; } = "";    
}
