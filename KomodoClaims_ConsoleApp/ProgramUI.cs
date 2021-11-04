

using KomodoClaims_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims_ConsoleApp
{

    //take care of next claim??
    //displaying list of claims?? 



    public class ProgramUI
    {
        private readonly ClaimsRepo claims = new ClaimsRepo();
        private readonly Queue<Claims> claimQueue = new Queue<Claims>();

        public void Run()
        {
            SeedContent();
            RunMenu();
            

        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello Claims Agent Austin \n" +
                    "What would you like to do? \n" +
                    "1. See All Claims \n" +
                    "2. Take Care Of Next Claim \n" +
                    "3. Enter A New Claim \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a number between 1 and 4. \n" +
                            "Press Enter to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ShowAllClaims()
        {
            Queue<Claims> claimsList = claims.SeeAllClaims();
            foreach (Claims c in claimsList)
            {
                DisplayClaims(c);
            }
            Console.ReadKey();
        }

        private void DisplayClaims(Claims claims)
        {
            Console.WriteLine($"ID: {claims.ClaimID}");
            Console.WriteLine($"Type: {claims.TypeOfClaim}");
            Console.WriteLine($"Description: {claims.Description}");
            Console.WriteLine($"Damage Amount: {claims.ClaimAmount}");
            Console.WriteLine($"Incident Date: {claims.DateOfIncident}");
            Console.WriteLine($"Date of Claim: {claims.DateOfClaim}");
            Console.WriteLine($"Valid: {claims.IsValid}");
        }

        private void TakeCareOfNextClaim()
        {

            Claims claimsQueue = claims.SeeNextClaim();

            DisplayClaims(claimsQueue);

            Console.ReadKey();

            Console.WriteLine("Do you want to deal with this claim now (y/n)?");

            string dealWith = Console.ReadLine().ToUpper();

            if(dealWith == "Y")
            {
                claimQueue.Dequeue();
            }
            else
            {
                claimQueue.Peek();   
            }


            Console.ReadKey();
        }

        private void EnterNewClaim()
        {
            Claims claim = new Claims();

            //Claim ID
            Console.WriteLine("You have chosen to add a new claim. \n" +
                "Please enter in a number for the new claim.");
            claim.ClaimID = int.Parse(Console.ReadLine());

            //Claim Type
            Console.WriteLine("What is the claim type? \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft");
            string claimType = Console.ReadLine();
            switch (claimType.ToUpper())
            {
                case "1":
                    claim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    claim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    claim.TypeOfClaim = ClaimType.Theft;
                    break;
                default:
                    Console.WriteLine("Please enter in a valid number between 1 and 3. \n" +
                        "Press enter to continue...");
                    break;
            }

            //Description
            Console.WriteLine("What happened? \n" +
                "Please enter in a description for the new claim.");
            claim.Description = Console.ReadLine();

            //Damage Amount
            Console.WriteLine("How much did the damage amount to? \n" +
                "Please enter the monetary damage amount.");
            claim.ClaimAmount = int.Parse(Console.ReadLine());

            //Incident Date
            Console.WriteLine("Please enter in the date that the incident happened.");
            claim.DateOfIncident = Convert.ToDateTime(Console.ReadLine());

            //Date of Claim
            Console.WriteLine("Please enter in the date that the claim was made.");
            claim.DateOfClaim = Convert.ToDateTime(Console.ReadLine());

            //Is Valid
            Console.WriteLine("Based on the information you have entered the claim...");
            Console.WriteLine(claim.IsValid);

            Console.ReadKey();

            claimQueue.Enqueue(claim);

            Console.WriteLine("The new claim has been added to the queue.");

            Console.ReadKey();
        }


        private void SeedContent()
        {

            Claims claim1 = new Claims(1, ClaimType.Car, "Car accident on 465", 400.00, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));

            claimQueue.Enqueue(claim1);

            Claims claim2 = new Claims(2, ClaimType.Home, "House fire in kitchen", 4000.00, new DateTime(2018, 04, 11), new DateTime(2018, 04, 27));

            claimQueue.Enqueue(claim2);


            Claims claim3 = new Claims(3, ClaimType.Theft, "Stolen pancakes", 4.00, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01));

            claimQueue.Enqueue(claim3);

        }
    }
}
