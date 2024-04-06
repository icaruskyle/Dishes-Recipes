using System;

public class Program
{
    static void Main(string[] args)
    {
        recipeInfo recipeDishes = new recipeInfo();
        recipeDishes.name = "Welcome to Recipes Dishes";

        Recipe recipeOne = new Recipe();
        recipeOne.Ingredients = "Chicken or Pork, Soyce Sauce," +
            " Vinegar, Garlic," +
            " Bay leaves, " +
            "Salt and Pepper";
        recipeOne.Instructions = """

            1. Marinate meat in soy sauce, vinegar, garlic, bay leaves, and peppercorns for at least 30 minutes.
            2. Simmer in a pot until meat is tender.
            3. Serve hot and enjoy!
            """;
        Recipe recipeTwo = new Recipe();
        recipeTwo.Ingredients = "Pork ribs or fish, Tamarind soup base,  Water, " +
            "Radish, Tomatoes, Kangkong (water spinach)";
        recipeTwo.Instructions = """

            1. Boil pork ribs or fish in water until tender.
            2.Add tamarind soup base and vegetables.
            3. Simmer until vegetables are cooked.
            4. Serve hot with rice!
            """;

        Recipe recipeThree = new Recipe();
        recipeThree.Ingredients = "Oxtail or tripe, " +
            "Peanut butter, Annatto seeds, Eggplant, String beans, Bok choy";
        recipeThree.Instructions = """

            1. Boil oxtail or tripe until tender.
            2. Add peanut butter and annatto seeds for flavor and color.
            3. Add vegetables and simmer until cooked.
            4. Serve hot with bagoong (shrimp paste) on the side!
            """;

        while (true)
        {
            Console.WriteLine("Choose a dish to view its recipe:");
            Console.WriteLine("1. Adobo");
            Console.WriteLine("2. Sinigang");
            Console.WriteLine("3. Kare-Kare");
            Console.Write("Enter your choice: ");
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    recipeDishes.DisplayRecipeInfo(recipeOne);
                    break;
                case "2":
                    recipeDishes.DisplayRecipeInfo(recipeTwo);
                    break;
                case "3":
                    recipeDishes.DisplayRecipeInfo(recipeThree);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }


    }

    }
