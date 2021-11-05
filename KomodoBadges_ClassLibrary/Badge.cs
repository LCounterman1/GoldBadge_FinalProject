using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges_ClassLibrary
{




    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }



        public Badge() 
        {
            DoorNames = new List<string>();
        }


        public Badge (int badgeID, List<string> doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
    }
}
