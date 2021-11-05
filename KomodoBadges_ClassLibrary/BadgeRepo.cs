using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges_ClassLibrary
{
    public class BadgeRepo
    {

        //crud

        protected readonly List<Badge> _badgeDirectory = new List<Badge>();


        public bool CreateNewBadge(Badge badge)
        {
            int startingCount = _badgeDirectory.Count;
            _badgeDirectory.Add(badge);
            bool wasAdded = _badgeDirectory.Count > startingCount ? true : false;
            return wasAdded;
        }


        private void SeedContent()
        {
            List<string> doorNumbers = new List<string>;
            doorNumbers.Add(A1);+
        }



        public Dictionary<int, Badge> GetBadges()
        {


            var badges = new Dictionary<int, Badge>();
            var theBadge = new Badge(123, Convert.FromBase64String(A1, B1, C1));
            badges.Add(1, theBadge);
            theBadge = new Badge(456, "A2, B2, C2");
            badges.Add(2, theBadge);
            theBadge = new Badge(789, "A3, B3,  C3");
            badges.Add(3, theBadge);

            return badges;
        }

        public List<Badge> ShowAllBadges()
        {
            return _badgeDirectory;
        }


        public Badge GetBadgeByID(int badgeID)
        {
            foreach (Badge info in _badgeDirectory)
            {
                if (info.BadgeID == badgeID)
                {
                    return (info);
                }
            }
            return null;
        }


        public bool UpdateDoorsForExistingBadge(int originalID, Badge newBadge)
        {
            Badge oldBadge = GetBadgeByID(originalID);

            if (oldBadge != null)
            {
                oldBadge.DoorNames = newBadge.DoorNames;
                return true;
            }
            else
            {
                return false;

            }

        }

        public bool RemoveDoorFromExistingBadge(Badge door)
        {


            int startingCount = _badgeDirectory.Count;
            _badgeDirectory.Remove(door);
            bool removeResult = _badgeDirectory.Count < startingCount ? true : false;
            return removeResult;
        }

     
    }
}
