using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    class ProgramUI
    {
        public void Start()
        {
            //SeedMenuItems();
            MainMenu();
        }

        private void MainMenu()
        {
            bool running = true;
            while (running)         
            {
                // Main Menu
                Console.WriteLine("Select option:\n" +
                    "1. Get all claims\n" +
                    "2. Get next claim\n" +
                    "3. Add new claim\n" +
                    "4. Update existing claim\n" +
                    "5. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Respond to user input
                switch (input)
                {
                    case "1":
                        // Get all claims
                       
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Get next claim
                       
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        // Add new claim
                       
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        // Update existing claim
                        
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

            }
        }
    }
}
