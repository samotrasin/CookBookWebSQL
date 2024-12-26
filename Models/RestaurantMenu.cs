
namespace CookBookWebSQL.Models{
    public class RestaurantMenu
    {
        public int Id { get; set; }
        public string MenuName {get; set;} = "";
        public double Price {get; set;}
        public string Recipe {get; set;} = "";
        public DateTime Created {get; set;} = DateTime.Now;
        public DateTime Updated {get; set;} = DateTime.Now;
        public List<RestaurantMenuImage> MenuImages {get; set;} = new List<RestaurantMenuImage>();
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    }
}

