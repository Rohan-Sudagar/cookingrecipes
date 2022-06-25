namespace CookingRecipes.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string RecipeUrl { get; set; }
        public string Category { get; set; }

        public Recipe(string name, string description, string imageurl, string recipeurl, string category)
        {
            Name = name;
            Description = description;
            ImageUrl = imageurl;
            RecipeUrl = recipeurl;
            Category = category;
        }

    }
}
