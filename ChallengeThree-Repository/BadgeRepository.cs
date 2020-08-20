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

    class BadgeRepository
    {
        Dictionary<int, List<string>> _badgeRepository = new Dictionary<int, List<string>>();

        // 1. CREATE -- create a new badge
        public void CreateNewBadge(Badge newBadge)
        {
            _badgeRepository.Add(newBadge.BadgeId, newBadge.DoorNames);
        }

        // 2. UPDATE -- update doors on an existing badge


        // 3. DELETE -- delete all doors from an existing badge
        public void DeleteDoorsFromBadge()
        {
            
        }

        // 4. GET -- show a list with all badge numbers and door access
        public Dictionary<int, List<string>> GetListOfBadgesAndDoors()
        {
            return _badgeRepository;
        }




    }
}
