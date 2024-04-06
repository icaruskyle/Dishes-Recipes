using System;
using System.Collections.Generic;


public class DishesRecipes
{
    public List<Recipe> recipeList = new List<Recipe>();

    public DishesRecipes()
    {
        Recipe recipeOne = new Recipe();
        recipeOne.Ingredients = "Chicken or Pork, Soyce Sauce," +
            " Vinegar, Garlic," +
            " Bay leaves, " +
            "Salt and Pepper";
        recipeOne.Instructions = "1. Marinate meat in soy sauce, vinegar, garlic, bay leaves, and peppercorns for at least 30 minutes." +
            "2. Simmer in a pot until meat is tender." +
            "3. Serve hot and enjoy!";
        recipeList.Add(recipeOne);

        Recipe recipeTwo = new Recipe();
        recipeTwo.Ingredients = "Pork ribs or fish, Tamarind soup base,  Water, " +
            "Radish, Tomatoes, Kangkong (water spinach)";
        recipeTwo.Instructions = "1. Boil pork ribs or fish in water until tender." +
            "2. Add tamarind soup base and vegetables., " +
            "3. Simmer until vegetables are cooked.," +
            "4. Serve hot with rice!";
        recipeList.Add(recipeTwo);

        Recipe recipeThree = new Recipe();
        recipeThree.Ingredients = "Oxtail or tripe, " +
            "Peanut butter, Annatto seeds, Eggplant, String beans, Bok choy";
        recipeThree.Instructions = "1. Boil oxtail or tripe until tender., " +
            "2. Add peanut butter and annatto seeds for flavor and color." +
            "3. Add vegetables and simmer until cooked." +
            "4. Serve hot with bagoong (shrimp paste) on the side!";
        recipeList.Add(recipeThree);

    }
    
    }

