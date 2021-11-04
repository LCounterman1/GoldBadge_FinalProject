using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoClaims_ClassLibrary
{
    public enum ClaimType
    {
        Car = 1,
        Home,
        Theft
    }


    public class Claims
    {
        //claim id
        //claim type  - car, home, theft
        //description
        //claim amount
        //date of incident
        //date of claim
        //is valid

        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public string IsValid
        {
            get
            {
                //return true or false based on date of incident 
                //false date of incident > 30 days
                //DateTime claimDate = new DateTime();
                //DateTime incidentDate = new DateTime();
                TimeSpan timeSpan = DateOfClaim - DateOfIncident;

                if (timeSpan.TotalDays < 30)
                {
                    return "is Valid";
                }
                else
                {
                    return "is not valid";
                }
            }
        }




        public Claims() { }

        public Claims(int claimID, ClaimType claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            TypeOfClaim = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }

}