using KomodoBadges_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges_ConsoleApp
{
    class ProgramUI
    {
        private readonly Badge _badges = new Badge();
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();
        public void Run()
        {
            //SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin! \n" +
                    "What would you like to do?\n" +
                    "1. Create a new badge \n" +
                    "2. Edit an exisiting badge \n" +
                    "3. Show a list of all badges \n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewBadgeID();
                        break;
                    case "2":
                        UpdateExistingBadge();
                        break;
                    case "3":
                        ShowAllBadges();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a number between 1 and 4. \n" +
                            "Press enter to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewBadgeID()
        {

            Console.WriteLine("You have chosen to create a new badge. \n" +
                "What is the number for the badge?");

            Badge addBadge = new Badge();
            addBadge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("OK. Now list a door that this badge needs access to.");

            addBadge.DoorNames = Console.ReadLine().ToLower();


            bool moreDoors = true;
            while (moreDoors)
            {

                Console.WriteLine("Does this badge need access to any other doors (y/n)?");

                string doorOption = Console.ReadLine().ToUpper();

                if (doorOption == "Y")
                {
                    Console.WriteLine("List a door that this badge needs access to.");

                    addBadge.DoorNames = Console.ReadLine().ToUpper();

                    Console.Clear();
                }
                else if (doorOption == "N")
                {
                    Console.WriteLine("You have chosen not to list any other access to doors. \n" +
                        "Press enter to continue...");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter Y or N");
                    break;
                }



            }

            _badgeRepo.CreateNewBadge(addBadge);
        }

        private void UpdateExistingBadge()
        {

            Badge updateBadge = new Badge();

            bool badgeUpdate = true;
            while (badgeUpdate)
            {

                Console.WriteLine("You have chosen to update an existing badge. \n" +
                    "Please enter the badge ID of the badge you would like to update.");

                _badgeRepo.GetBadges();

                string idBadge = Console.ReadLine();
//trouble
                Badge update = _badgeRepo.GetBadgeByID(int.Parse(idBadge));
                

                bool accessEdit = true;
                while (accessEdit)
                {

                    Console.WriteLine("What would you like to do? \n" +
                        "1. Add access to a door. \n" +
                        "2. Remove access from all doors \n" +
                        "3. Exit");

                    string editOption = Console.ReadLine();


                    switch (editOption)
                    {

                        case "1":
                            Console.WriteLine("Which door would you like to add access to?");

                            update.DoorNames = Console.ReadLine().ToUpper();

                            bool addMoreAccess = true;
                            while (addMoreAccess)
                            {

                                Console.WriteLine("Does this badge need access to any other doors (y/n)?");

                                string moreAccess = Console.ReadLine().ToUpper();

                                if (moreAccess == "Y")
                                {
                                    Console.WriteLine("List a door that this badge needs access to.");

                                    update.DoorNames = Console.ReadLine().ToUpper();
                                    Console.Clear();
                                }
                                else if (moreAccess == "N")
                                {
   
                                    Console.WriteLine("You have chosen not to list any other access to doors. \n" +
                                        "Press enter to continue...");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter Y or N \n" +
                                        "Press enter to continue...");
                                    break;
                                }
                            }
                            _badgeRepo.UpdateDoorsForExistingBadge(int.Parse(idBadge), update);
                            break;

                        case "2":
                            Console.WriteLine("All doors have been removed from this badge. \n" +
                                "Press enter to continue...");

                            _badgeRepo.RemoveDoorsFromExistingBadge(update);

                            break;

                        case "3":
                            badgeUpdate = false;
                            break;
                        default:
                            Console.WriteLine("Please select a number between 1 and 3. \n" +
                                "Press enter to continue...");
                            break;

                            
                    }
                    
                    break;


                }
            }

            

        }

        private void ShowAllBadges()
        {

            Dictionary<int, Badge> badges = _badgeRepo.GetBadges();

            foreach (KeyValuePair<int, Badge> kvp in badges)
            {

                Badge badge = kvp.Value;
                Console.WriteLine("Badge ID = {0} \n" +
                    "Door Access = {1}", badge.BadgeID, badge.DoorNames);

                Console.WriteLine("--------------------------------");
            }
            Console.ReadKey();
        }
    }
}