using System;
using ChallengeThree_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    class ProgramUI
    {
        // FIELD
        private BadgeRepository badgeRepository = new BadgeRepository();

        //private ClaimRepository _claimRepo = new ClaimRepository();
        //public Queue<Claim> claimQueue = new Queue<Claim>();
        public void Start()
        {
            //SeedBadges();
            MainMenu();
        }

        private void MainMenu()
        {
            bool running = true;
            while (running)
            {
                // Main Menu
                Console.WriteLine("Hello Security Admin, What would you like to do?\n");
                Console.WriteLine("Select option:\n" +
                    "1. Add badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Respond to user input
                switch (input)
                {
                    case "1":
                        // Add badge

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Edit a badge

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        // List all badges

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        // Exit
                        Console.WriteLine("bye!");
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


        // 1. ADD BADGE


        // 2. EDIT BADGE


        // 3. DISPLAY ALL BADGES


        // SEED BADGES -- BadgeID (int), List of door names 
        private void SeedBadges()
        {
            Badge badgeOne = new Badge(1, new List<>);
        }


    }
}
