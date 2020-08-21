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
                        AddBadge();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Edit a badge
                        EditBadge();
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
                        Console.ReadKey();
                        break;
                }

            }
        }

        // 1. ADD BADGE
        public void AddBadge()
        {
            Console.Clear();
            Console.WriteLine("Badge number: ");
            int badgeId = Convert.ToInt32(Console.ReadLine());

            _badgeRepo.AddNewBadge(badgeId);
            AddDoor(badgeId);

            bool running = true;
            while (running)
            {
                Console.WriteLine("Any other doors(yes/no)?");
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "yes":
                        AddDoor(badgeId);
                        break;
                    case "no":
                        Console.WriteLine("Press any key to return to menu");
                        Console.Clear();
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        Console.ReadKey();
                        break;
                }
            }

        }

        public void AddDoor(int badgeId)
        {
            Console.WriteLine("What door does it need to access: ");
            string addDoor = Console.ReadLine();

            _badgeRepo.AddDoor(badgeId, addDoor);
        }

        // 2. EDIT BADGE -- Remove a door & Add a door
       public void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?");
            int badgeId = Convert.ToInt32(Console.ReadLine());

            if (_badgeRepo.GotsTheKey(badgeId))
            {
                bool running = true;
                while (running)
                {
                    Console.WriteLine("1. Add door\n" +
                        "2. Delete door\n" +
                        "3. Delete all doors\n" +
                        "4. Return to menu");

                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            AddDoor(badgeId);
                            Console.WriteLine("Door added successfully. Press any key to continue.");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.WriteLine("Which door do you want to remove? ");
                            _badgeRepo.GetBadgeById(badgeId);
                            string doorDelete = Console.ReadLine();
                            _badgeRepo.DeleteOneDoor(badgeId, doorDelete);
                            Console.WriteLine("Door deleted successfully");
                            Console.ReadKey();
                            break;
                        case "3":
                            _badgeRepo.DeleteAllDoors(badgeId);
                            Console.WriteLine("All doors deleted");
                            Console.ReadKey();
                            break;
                        case "4":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("not valid option");
                            break;
                    }
                } 
            }
        }





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
