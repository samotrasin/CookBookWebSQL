using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookWebSQL.Models{

    public partial class Restaurant
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Description {get;set;} = "";
        public DateTime CreatedDate {get;set;} = DateTime.Now;
        public DateTime UpdatedDate {get;set;} = DateTime.Now;
        public List<RestaurantImage> Images {get;set;} = new List<RestaurantImage>();
        public List<RestaurantMenu> RestaurantMenus { get; set; } = new List<RestaurantMenu>();
    }
}

