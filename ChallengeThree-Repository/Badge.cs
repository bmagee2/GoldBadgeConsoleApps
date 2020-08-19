using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repository
{
    public class Badge
    {
        // Dictionary
        //Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
        //keyAndValue.Add("Teacher", "Joshua");
        //Console.WriteLine("your instructor is " + keyAndValue["Teacher"]);

        // CONSTRUCTORS 
        public Badge() { }
        public Badge(int badgeId, string badgeName)
        {
            BadgeId = badgeId;
            // List or string
            BadgeName = badgeName;
        }

        // PROPERTIES -- BadgeID (int), List of door names (strings), name for the badge
        public int BadgeId { get; set; }
        // List or string
        public string BadgeName { get; set; }

    }
}
