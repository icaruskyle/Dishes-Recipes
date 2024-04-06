using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

public class recipeInfo
{
    public string name;
    List<Recipe> recipeList = new List<Recipe>();
    public void AddRecipe(Recipe recipe)
    {
        recipeList.Add(recipe);
    }
    public void DisplayRecipeInfo(Recipe recipe)
    {
        Console.WriteLine(name);

        Console.WriteLine("Ingredients: " + recipe.Ingredients);
        
        Console.WriteLine("Instructions: " + recipe.Instructions);

        Console.WriteLine("   ");
    }
}
