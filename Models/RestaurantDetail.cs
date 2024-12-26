using System.ComponentModel.DataAnnotations;
namespace CookBookWebSQL.Models
{

    public partial class Restaurant
    {
        [Required]
        public string Address { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? GoogleMap { get; set; } = "";
        public int RestaurantDetailId { get; set; }
        public string? RestaurantDetailName { get; set; }
        public string? RestaurantDetailAddress { get; set; }
        public double RestaurantDetailLatitude { get; set; }
        public double RestaurantDetailLongitude { get; set; }
        public string? RestaurantDetailGoogleMap { get; set; }
        public string? RestaurantDetailDescription { get; set; }
    }
}