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
        public string DoorNames { get; set; }



        public Badge() { }

        public Badge (int badgeID, string doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
    }
}
