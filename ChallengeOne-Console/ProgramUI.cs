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
       
        // starts app
        public void Start()
        {
            UserOptions();
        }

        private void UserOptions()
        {
            bool running = true;    
            while (running)         // runs until a specific condition is met
            {
                // Display user options
                Console.WriteLine("Select option:\n" +
                    "1. Get\n" +
                    "2. Add\n" +
                    "3. Delete\n" +
                    "4. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Respond to user input
                switch (input)
                {
                    case "1":
                        // Get
                        GetMenuItems();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Add
                        AddNewMenuItem();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        // Delete
                        DeleteMenuItem();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
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

        // GET ALL MENU ITEMS
        private void GetMenuItems()
        {

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
            newMenuItem.ItemPrice = decimal.Parse(itemPrice);

            // LIST OF INGREDIENTS
            //Console.WriteLine("List item ingredient: ");
            // add a list of strings?
            // Casting? -- create method video @ 12mins

            _menuRepo.AddMenuItem(newMenuItem);     // adds new item to _menuRepo
        }

        // DELETE MENU ITEM
        private void DeleteMenuItem()
        {

        }

    }
}
