using KomodoCafe_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_ConsoleApp
{
    class ProgramUI
    {
        private readonly MenuRepo _menuRepo = new MenuRepo();
        private readonly Menu _ingredientsList = new Menu();


        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to KOMODO CAFE application \n" +
                    "Here is where you can create, delete and see all items in your menu \n" +
                    "Please enter in the number of the option you would like to select. \n" +
                    "1. See all items in your menu \n" +
                    "2. Add an item to your menu \n" +
                    "3. Delete an item from your menu \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        GetAllMenuItems();
                        break;
                    case "2":
                        AddItemToMenu();
                        break;
                    case "3":
                        DeleteItemFromMenu();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4. \n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;

                }
            }
        }

        private void AddItemToMenu()
        {
            Menu item = new Menu();
           
                //meal number
                Console.WriteLine("Let's add some meals to your menu! \n" +
                    "Please enter in a number for the new meal number.");
                item.MealNumber = int.Parse(Console.ReadLine());

                //meal name
                Console.WriteLine("Now let's give your meal a name \n" +
                    "Please enter in a name for the new meal.");
                item.MealName = Console.ReadLine();

                //meal description
                Console.WriteLine("Please enter in a description for the new meal.");
                item.MealDescription = Console.ReadLine();

                //meal ingredients
                Console.WriteLine("Please enter the ingredients you would like to add to the meal.");
                item.MealIngredients = Console.ReadLine();

                //meal price
                Console.WriteLine("Please enter in a price for the new meal.");
                try
                {
                    item.MealPrice = Convert.ToDecimal(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter in a a valid decimal.");
                }

                Console.ReadKey();

                _menuRepo.AddItemToMenu(item);

                Console.WriteLine("The new meal has been added to the menu!");

                Console.ReadKey();           

        }

        private void GetAllMenuItems()
        {
            List<Menu> menuList = _menuRepo.GetAllItems();
            foreach (Menu meal in menuList)
            {
                DisplayMenu(meal);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void DisplayMenu(Menu item)
        {
            Console.WriteLine($"Number: {item.MealNumber}");
            Console.WriteLine($"Meal: {item.MealName}");
            Console.WriteLine($"Description: {item.MealDescription}");
            Console.WriteLine($"Ingredients: {item.MealIngredients}");
            Console.WriteLine($"Price: {item.MealPrice}");
        }

        private void DeleteItemFromMenu()
        {
            Console.WriteLine("You have chosen to delete a meal from your Menu. \n" +
                "Below is a list of the Meal Names that you can delete.");

            GetAllMenuItems();

            Console.WriteLine("What is the name of the meal that you would like to delete?");

            string existingItem = Console.ReadLine();

            Menu mealRemove = _menuRepo.GetMealByMealName(existingItem);

            Console.WriteLine("This meal has been deleted.");

            Console.ReadKey();

            _menuRepo.DeleteItemFromMenu(mealRemove);

        }
    }
}
