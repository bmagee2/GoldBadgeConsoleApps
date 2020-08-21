using ChallengeThree_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeThree_Repository.Badge;

namespace ChallengeThree_Console
{
    public class ProgramUI
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();
        public Dictionary<int, List<string>> badgeDictionary = new Dictionary<int, List<string>>();
       
        public void Start()
        {
            _badgeRepo.SeedBadges();
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
                        ShowAllBadges();
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
      
        private void ShowAllBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> listOfBadges = _badgeRepo.ShowListOfBadges();

            foreach (KeyValuePair<int, List<string>> badge in listOfBadges)
            {
                int ShowBadgeKey = badge.Key;
                foreach (string door in badge.Value)
                {
                    string showDoor = door;
                    Console.WriteLine(ShowBadgeKey);
                    Console.WriteLine(showDoor);
                }
            }
        }


    }
}
