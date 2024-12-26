using System.ComponentModel.DataAnnotations;

namespace CookBookWebSQL.Models
{
    public partial class RestaurantDetail
    {
        public int RestaurantDetailId { get; set; }
        public string RestaurantDetailName { get; set; } = "";
        public string RestaurantDetailAddress { get; set; } = "";
        public double RestaurantDetailLatitude { get; set; }
        public double RestaurantDetailLongitude { get; set; }
        public string RestaurantDetailGoogleMap { get; set; } = "";
        public string RestaurantDetailDescription { get; set; } = "";
    }
}
