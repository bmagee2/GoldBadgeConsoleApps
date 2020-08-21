using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repository
{
    // Dictionary example
    //Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
    //keyAndValue.Add("Teacher", "Joshua");
    //Console.WriteLine("your instructor is " + keyAndValue["Teacher"]);

    // Create a dictionary of badges -- key for the dictionary will be the BadgeID, value for the dictionary will be the List of Door Names.
    // CRUD
    /* 1. create a new badge
       2. update doors on an existing badge.
       3. delete all doors from an existing badge.
       4. show a list with all badge numbers and door access
    */

    public class BadgeRepository
    {
       public Dictionary<int, List<string>> _badgeRepository = new Dictionary<int, List<string>>();

        // 1. CREATE -- create a new badge
        public void AddNewBadge(int badgeId)
        {
            List<string> DoorNames = new List<string>();
            Badge newBadge = new Badge(badgeId, DoorNames);

            _badgeRepository.Add(newBadge.BadgeId, newBadge.DoorNames);
        }


        // 2. UPDATE -- update door access on an existing badge -- remove or add door
        public void AddDoor(int badgeId, string door)
        {
            _badgeRepository[badgeId].Add(door);
        }

        public void DeleteOneDoor(int badgeId, string door)
        {
            _badgeRepository[badgeId].Remove(door);
        }


        // 3. DELETE -- delete all doors from an existing badge
        public void DeleteAllDoors(int badgeId)
        {
            _badgeRepository[badgeId].Clear();
        }


        // 
        public bool GotsTheKey(int key)
        {
            bool validKey = _badgeRepository.ContainsKey(key);
            if (validKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool DeleteBadge(int badgeID)
        //{
        //    return _badgeRepository.Remove(badgeID);
        //}

        // 4. GET -- show a list with all badge numbers and door access
        public Dictionary<int, List<string>> ShowListOfBadges()
        {
            return _badgeRepository;
        }

       // 
        public Badge GetBadgeById(int badgeId)
        {
            foreach (var badge in _badgeRepository)
            {
                if (badge.Key == badgeId)
                {
                    Badge newBadge = new Badge(badge.Key, badge.Value);

                    return newBadge;
                }
            }

            return null;
        }

        // SEED METHOD
        public void SeedBadges()
        {
            _badgeRepository.Add(1, new List<string> { "DoorA" });
            _badgeRepository.Add(2, new List<string> { "DoorB" });
            _badgeRepository.Add(3, new List<string> { "DoorC" });
        }
    }
}
