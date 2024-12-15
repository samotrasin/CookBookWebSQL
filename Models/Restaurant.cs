namespace CookBookWebSQL.Models{
    public class Restaurant{
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Description {get;set;} = "";
        public DateTime CreatedDate {get;set;} = DateTime.Now;
        public DateTime UpdatedDate {get;set;} = DateTime.Now;
        public List<RestaurantImage> Images {get;set;} = new List<RestaurantImage>();

    }
}