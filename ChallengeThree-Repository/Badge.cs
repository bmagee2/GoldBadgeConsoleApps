using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repository
{
    public class Badge
    {

        // CONSTRUCTORS 
        public Badge() { }
        public Badge(int badgeId, List<string> doorNames)
        {
            BadgeId = badgeId;
            DoorNames = doorNames;
            
        }

        // PROPERTIES -- BadgeID (int), List of door names 
        public int BadgeId { get; set; }
        //public List<DoorNamesForAccess> DoorNames { get; set; }
        public List<string> DoorNames { get; set; }

    }

    //public class DoorNamesForAccess
    //{
    //    public DoorNamesForAccess(string doorName)
    //    {
    //        DoorName = doorName;
    //    }
    //    public string DoorName { get; set; }
    //}

}
