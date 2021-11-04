using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims_ClassLibrary
{
    public class ClaimsRepo
    {
        protected readonly Queue<Claims> claimQueue = new Queue<Claims>();
        //crud

        public bool AddNewClaim(Claims claim)
        {
            
            // add items to queue

            int startingCount = claimQueue.Count;
            claimQueue.Enqueue(claim);
            bool wasAdded = claimQueue.Count > startingCount ? true : false;
            return wasAdded;

            
        }

        public Queue<Claims> SeeAllClaims()
        {
            return claimQueue;
        }

        public Claims SeeNextClaim()
        {
            return claimQueue.Peek();
        }


        public Claims GetClaimByClaimID(int claimID)
        {
            foreach (Claims claim in claimQueue)
            {
                if (claim.ClaimID == claimID)
                {
                    return claim;
                }
            }
            return null;

        }

        public Claims PullClaim()
        {
            Claims c1 = claimQueue.Dequeue();
            Console.WriteLine(c1.ClaimID + "-" + c1.Description);
            Console.WriteLine("Total items in the queue = " + claimQueue.Count);
            return c1;

        }

    }
}

  




