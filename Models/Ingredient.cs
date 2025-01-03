﻿namespace CookBookWebSQL.Models
{

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
         public string CategoryIngredient {get ; set ;} = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Nutrition { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public List<IngredientImage> Images { get; set; } = new List<IngredientImage>();
    }
}