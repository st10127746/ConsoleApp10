using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }
    }

    public class Step
    {
        public int Number { get; set; }
        public string Description { get; set; }
    }

    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public double CalculateTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories);
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity /= ingredient.Quantity;
            }
        } }
    public class Program
    {
        private static List<Recipe> recipes = new List<Recipe>();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Enter a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Select a recipe to display");
                Console.WriteLine("4. Clear all data");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        EnterNewRecipe();
                        break;
                    case "2":
                        DisplayAllRecipes();
                        break;
                    case "3":
                        SelectRecipeToDisplay();
                        break;
                    case "4":
                        ClearAllData();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void EnterNewRecipe()
        {
            Recipe recipe = new Recipe();

            Console.Write("Enter the name of the recipe: ");
            recipe.Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            recipe.Ingredients = new List<Ingredient>();
            for (int i = 1; i <= ingredientCount; i++)
            {
                Ingredient ingredient = new Ingredient();

                Console.Write($"Enter the name of ingredient {i}: ");
                ingredient.Name = Console.ReadLine();

                Console.Write($"Enter the quantity of ingredient {i}: ");
                ingredient.Quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for ingredient {i}: ");
                ingredient.Unit = Console.ReadLine();

                Console.Write($"Enter the number of calories for ingredient {i}: ");
                ingredient.Calories = double.Parse(Console.ReadLine());

                Console.Write($"Enter the food group for ingredient {i}: ");
                ingredient.FoodGroup = Console.ReadLine();

                recipe.Ingredients.Add(ingredient);
                Console.WriteLine();
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            recipe.Steps = new List<Step>();
            for (int i = 1; i <= stepCount; i++)
            {
                Step step = new Step();

                Console.Write($"Enter step {i}: ");
                step.Description = Console.ReadLine();
                step.Number = i;

                recipe.Steps.Add(step);
                Console.WriteLine();
            }

            recipes.Add(recipe);

            Console.WriteLine("Recipe added successfully!");
        }

        private static void DisplayAllRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
            }
            else
            {
                Console.WriteLine("All Recipes:");
                Console.WriteLine();

                foreach (var recipe in recipes.OrderBy(r => r.Name))
                {
                    Console.WriteLine(recipe.Name);
                }
            }
        }

        private static void SelectRecipeToDisplay()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
            }
            else
            {
                Console.WriteLine("Select a recipe to display:");
                Console.WriteLine();

                int i = 1;
                foreach (var recipe in recipes.OrderBy(r => r.Name))
                {
                    Console.WriteLine($"{i}. {recipe.Name}");
                    i++;
                }

                Console.WriteLine();

                Console.Write("Enter the number of the recipe: ");
                int recipeNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
                {
                    Recipe selectedRecipe = recipes.OrderBy(r => r.Name).ToList()[recipeNumber - 1];
                    DisplayRecipe(selectedRecipe);
                }
                else
                {
                    Console.WriteLine("Invalid recipe number.");
                }
            }
        }

        private static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine($"Recipe: {recipe.Name}");
            Console.WriteLine();

            Console.WriteLine("Ingredients:");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine();

            Console.WriteLine("Steps:");
            foreach (var step in recipe.Steps)
            {
                Console.WriteLine($"{step.Number}. {step.Description}");
            }

            Console.WriteLine();

            Console.Write("choose a option to scale the quantities press 1 for half(0.5)\n" +
                "  press 2 for double 2\n" +
                " press 3 for triple 3 or\n" +
                " press 4 to reset the quantities? (s/r/n): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice==1) {
                Console.WriteLine("You have chosen 0.5");
            
            }
            if(choice==2) { Console.WriteLine("You have chosen 2"); 
            
            }
            if(choice==3) { Console.WriteLine("You have chosen 3");
            
            }
            if(choice==4) { Console.WriteLine("Quantities have been reset");}

        }


  private static void ClearAllData()
        {
            recipes.Clear();
            Console.WriteLine("All data cleared.");
        }


        }

      
    }


