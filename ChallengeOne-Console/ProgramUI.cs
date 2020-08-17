using ChallengeOne_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Console
{
    // single responsibility of ProgramUI class -- run all ProgramUI methods
    class ProgramUI
    {
        // Field -- calling MenuRepository and Adding to list; _menuRepo exists in entire ProgramUI instance
        private MenuRepository _menuRepo = new MenuRepository();

        //List<string> ingredients = new List<string>;
        
        // starts app
        public void Start()
        {
            SeedMenuItems();
            UserOptions();
        }

        private void UserOptions()
        {
            bool running = true;    
            while (running)         // runs until a specific condition is met
            {
                // Display user options
                Console.WriteLine("Select option:\n" +
                    "1. Get all menu items\n" +
                    "2. Get item by name\n" +
                    "3. Add new item\n" +
                    "4. Delete item\n" +
                    "5. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Respond to user input
                switch (input)
                {
                    case "1":
                        // Get all items
                        DisplayAllMenuItems();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Get one item by name
                        DisplayMenuItemByName();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        // Add
                        AddNewMenuItem();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        // Delete
                        DeleteMenuItem();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        // Exit
                        Console.WriteLine("bitch, bye");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        break;
                }

                //Console.WriteLine("Press any key to continue");
                //Console.ReadKey();
                //Console.Clear();
            }
        }

        // DISPLAY ALL MENU ITEMS
        private void DisplayAllMenuItems()
        {
            Console.Clear();
            List<Menu> listOfMenuItems = _menuRepo.GetAllMenuItems();

            foreach (Menu item in listOfMenuItems)
            {
                Console.WriteLine($"Item Number: {item.ItemNumber}\n" +
                    $"Item Name: {item.ItemName}\n" +
                    $"Item Description: {item.ItemDescription}\n" +
                    $"Item Price: ${item.ItemPrice}");
            }
        }

        // DISPLAY MENU ITEM BY NAME
        private void DisplayMenuItemByName()
        {
            Console.Clear();
            // Get name 
            Console.WriteLine("Enter name of item: ");
            string item = Console.ReadLine();

            // Find item & save
            Menu menuItem = _menuRepo.GetMenuItemByName(item);

            // Display item (if not null)
            if (menuItem != null)
            {
                Console.WriteLine($"Item Number: {menuItem.ItemNumber}\n" +
                    $"Item Name: {menuItem.ItemName}\n" +
                    $"Item Description: {menuItem.ItemDescription}\n" +
                    $"Item Price: ${menuItem.ItemPrice}");
            }
            else
            {
                Console.WriteLine("that's not a menu item");
            }
        }

        // ADD MENU ITEM
        private void AddNewMenuItem()
        {
            Console.Clear();
            // Reference to MenuRepository
            Menu newMenuItem = new Menu();

            // Item Number
            // give count of number of current items? (from Repository video) OR not have a setter for itemNumber?
            Console.WriteLine("Item number: ");
            string itemNumber = Console.ReadLine();
            newMenuItem.ItemNumber = int.Parse(itemNumber);

            // Item Name
            Console.WriteLine("Item name: ");
            newMenuItem.ItemName = Console.ReadLine().ToLower();

            // Item Description
            Console.WriteLine("Item description: ");
            newMenuItem.ItemDescription = Console.ReadLine().ToLower();

            // Item Price
            Console.WriteLine("Item price: $");
            string itemPrice = Console.ReadLine();
            newMenuItem.ItemPrice = double.Parse(itemPrice);

            // LIST OF INGREDIENTS
            //Console.WriteLine("List item ingredient: ");
            // add a list of strings?
            // Casting? -- create method video @ 12mins

            _menuRepo.AddNewMenuItem(newMenuItem);     // adds new item to _menuRepo
        }

        // DELETE MENU ITEM
        private void DeleteMenuItem()
        {
            DisplayAllMenuItems();
            // Get item
            Console.WriteLine("Enter name of item you'd like to delete: ");
            string selection = Console.ReadLine();
            // Delete item
            bool wasDeleted = _menuRepo.DeleteMenuItem(selection);
            // Was or Wasn't deleted
            if (wasDeleted)
            {
                Console.WriteLine("Item was deleted");
            }
            else
            {
                Console.WriteLine("Item was not deleted");
            }

        }


        // SEED MENU ITEMS -- needs LIST OF INGREDIENTS
        private void SeedMenuItems()
        {
            Menu cheeseSandwich = new Menu(3, "Cheese Sandwich", "Bread and choice of cheese", 4.00);
            Menu chocolateChipCookie = new Menu(4, "Chocolate Chip Cookie", "Homemade chocolate chip cookie", 2.00);
            Menu croissant = new Menu(6, "Croissant", "French pastry", 3.00);

            _menuRepo.AddNewMenuItem(cheeseSandwich);
            _menuRepo.AddNewMenuItem(chocolateChipCookie);
            _menuRepo.AddNewMenuItem(croissant);
        }

    }
}
