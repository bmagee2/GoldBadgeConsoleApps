using ChallengeTwo_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static ChallengeTwo_Repository.Claim;

namespace ChallengeTwo_Console
{
    class ProgramUI
    {
        // FIELD
        private ClaimRepository _claimRepo = new ClaimRepository();
        public Queue<Claim> claimQueue = new Queue<Claim>();
        public void Start()
        {
            SeedClaims();
            MainMenu();
        }

        private void MainMenu()
        {
            bool running = true;
            while (running)         
            {
                // Main Menu
                Console.WriteLine("Select option:\n" +
                    "1. Get all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Add new claim\n" +
                    "4. Update existing claim\n" +
                    "5. Exit");

                // Get user input
                string input = Console.ReadLine();

                // Respond to user input
                switch (input)
                {
                    case "1":
                        // Get all claims
                        DisplayAllClaims();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        // Get next claim -- <QUEUE>
                        GetNextClaim();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        // Add new claim
                        AddNewClaim();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        // Update existing claim
                        UpdateExistingClaim();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        // Exit
                        Console.WriteLine("bitch, bye");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        break;
                }

            }
        }

        // 1. DISPLAY ALL CLAIMS -- Id(int), Type(emun), Description(string), Amount(double), DateOfIncident(DateTime), DateOfClaim(DateTime), isValid(bool)
        private void DisplayAllClaims()
        {
            Console.Clear();
            Queue<Claim> listOfClaims = _claimRepo.GetAllClaims();

            foreach (Claim claim in listOfClaims)
            {
                Console.WriteLine($"Claim Id: {claim.ClaimId}\n" +
                    $"Claim Type: {claim.TypeOfClaim} \n" +
                    $"Claim Description: {claim.ClaimDescription}\n" +
                    $"Claim Amount: ${claim.ClaimAmount}\n" +
                    $"Date of Incident: {claim.DateOfIncident.ToShortDateString()}\n" +
                    $"Date of Claim: {claim.DateOfClaim.ToShortDateString()}\n" +
                    $"Is the claim valid: {claim.ClaimIsValid}");
            }

        }

        // 2. GET NEXT CLAIM IN QUEUE
        //private void GetNextClaim()
        //{
        //    Queue<Claim> queueOfClaims = _claimRepo.GetAllClaims();
        //    bool queueWorking = true;
        //    while (queueWorking)
        //    {
        //        if (queueOfClaims.Count > 0)
        //        {
        //            var next = queueOfClaims.Peek();
        //            DisplayOneClaim(next);
        //        }
        //        Console.WriteLine("Do you want to deal with this claim now(y/n)?");
        //        string userInput = Console.ReadLine();
        //        if (userInput == "y")
        //        {
        //            queueOfClaims.Dequeue();
        //        }
        //        else if (userInput == "n")
        //        {
        //            queueWorking = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("invaild.");
        //        }
        //    }
        //}

        // 2. GET NEXT CLAIM IN QUEUE
        //private void DisplayClaimsQueue()
        //{
        //    Queue<Claim> queueOfClaims = _claimRepo.GetClaimsQueue();

        //    foreach (Claim claim in queueOfClaims)
        //    {
        //        Console.WriteLine($"Claim Id: {claim.ClaimId}\n" +
        //            $"Claim Type: {claim.TypeOfClaim} \n" +
        //            $"Claim Description: {claim.ClaimDescription}\n" +
        //            $"Claim Amount: ${claim.ClaimAmount}\n" +
        //            $"Date of Incident: {claim.DateOfIncident}\n" +
        //            $"Date of Claim: {claim.DateOfClaim}\n" +
        //            $"Is the claim valid: {claim.ClaimIsValid}");
        //    }
        //}

        // 2. DISPLAY NEXT CLAIM IN QUEUE
        private void DisplayOneClaim(Claim claim)
        {
            Console.WriteLine($"Claim Id: {claim.ClaimId}\n" +
                    $"Claim Type: {claim.TypeOfClaim} \n" +
                    $"Claim Description: {claim.ClaimDescription}\n" +
                    $"Claim Amount: ${claim.ClaimAmount}\n" +
                    $"Date of Incident: {claim.DateOfIncident.ToShortDateString()}\n" +
                    $"Date of Claim: {claim.DateOfClaim.ToShortDateString()}\n" +
                    $"Is the claim valid: {claim.ClaimIsValid}");
        }

        // 2. GET NEXT CLAIM
        //private void GetNextClaim()
        //{
        //    // User prompt -- Do you want to deal with this claim now(y/n)? y
        //    string userInput = Console.ReadLine().ToLower();
        //    switch (userInput)
        //    {
        //        case "y": // -- claim will be pulled off the top of the queue
        //            // new method 
        //            break;
        //        case "n": // -- will go back to the main menu
        //            MainMenu();
        //            break;
        //        default:
        //            break;
        //    }
        //}


        // 3. ADD NEW CLAIM
        private void AddNewClaim()
        {
            Console.Clear();
            // Reference to ClaimRepository
            Claim newClaim = new Claim();

            // ID
            Console.WriteLine("Claim Id:");
            string claimId = Console.ReadLine();
            newClaim.ClaimId = int.Parse(claimId);

            // TYPE
            Console.WriteLine("Claim type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");

            string claimType = Console.ReadLine();
            int claimTypeSelection = int.Parse(claimType);
            newClaim.TypeOfClaim = (ClaimType)claimTypeSelection;
            

            // DESCRIPTION
            Console.WriteLine("Claim description:");
            newClaim.ClaimDescription = Console.ReadLine().ToLower();

            // AMOUNT
            Console.WriteLine("Claim amount:");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(claimAmount);

            // DATE OF INCIDENT
            Console.WriteLine("Date of incident:");
            string dateOfIncident = Console.ReadLine();
            DateTime newDateOfIndcident = Convert.ToDateTime(dateOfIncident);

            // DATE OF CLAIM
            Console.WriteLine("Date of claim:");
            string dateOfClaim = Console.ReadLine();
            DateTime newDateOfClaim = Convert.ToDateTime(dateOfClaim);


            _claimRepo.AddNewClaim(newClaim);   // adds new item to _claimRepo
        }


        // 4. UPDATE CLAIM
        private void UpdateExistingClaim()
        {
            // Reference to ClaimRepository
            Claim newClaim = new Claim();

            // Display all claims
            DisplayAllClaims();

            // User input- get claim by ID
            Console.WriteLine("Enter claim ID to update:");

            // Get claim
            string oldClaim = Console.ReadLine();
            newClaim.ClaimId = int.Parse(oldClaim); // parsed int to string

            // Update = AddNewClaim()
            
            // TYPE
            Console.WriteLine("Claim type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");

            string claimType = Console.ReadLine();
            int claimTypeSelection = int.Parse(claimType);
            newClaim.TypeOfClaim = (ClaimType)claimTypeSelection;


            // DESCRIPTION
            Console.WriteLine("Claim description:");
            newClaim.ClaimDescription = Console.ReadLine().ToLower();

            // AMOUNT
            Console.WriteLine("Claim amount:");
            string claimAmount = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(claimAmount);

            // DATE OF INCIDENT
            Console.WriteLine("Date of incident:");
            string dateOfIncident = Console.ReadLine();
            DateTime newDateOfIndcident = Convert.ToDateTime(dateOfIncident);

            // DATE OF CLAIM
            Console.WriteLine("Date of claim:");
            string dateOfClaim = Console.ReadLine();
            DateTime newDateOfClaim = Convert.ToDateTime(dateOfClaim);
                                
            _claimRepo.UpdateExistingClaim(newClaim.ClaimId, newClaim); 
        }



        // SEED CLAIMS -- Id(int), Type(emun), Description(string), Amount(double), DateOfIncident(DateTime), DateOfClaim(DateTime), isValid(bool)
        private void SeedClaims()
        {
            Claim claimOne = new Claim(1, ClaimType.Car, "broken window", 1000.00, new DateTime(1992, 5, 4), new DateTime(1992, 7, 7));

            Claim claimTwo = new Claim(2, ClaimType.Home, "attacked by chipmunks", 3000.00, new DateTime(1992, 7, 4), new DateTime(1992, 7, 7));
            Claim claimThree = new Claim(3, ClaimType.Theft, "stolen car", 10000.00, new DateTime(1992, 7, 4), new DateTime(1992, 7, 7));

            _claimRepo.AddNewClaim(claimOne);
            _claimRepo.AddNewClaim(claimTwo);
            _claimRepo.AddNewClaim(claimThree);
        }
    }
}
