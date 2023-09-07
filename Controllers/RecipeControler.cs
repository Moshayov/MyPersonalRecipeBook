using Newtonsoft.Json;

namespace MyPersonalRecipeBook.Controllers
{
    public class RecipeControler
    {
        public void Add_recipe()
        {
            for (int i = 0; i < 250; i++)
            {
                using (var context = new RecipeDbContext())
                {
                    try
                    {
                        //get values from the recipes cloud
                        DAL.RecipeAdapter d_recipe = new DAL.RecipeAdapter();
                        string json = d_recipe.GetRecipes(i.ToString());
                        Recipe recipe = JsonConvert.DeserializeObject<Recipe>(json);
                        context.Recipes.Add(recipe);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }
}
