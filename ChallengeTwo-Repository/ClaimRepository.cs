﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repository
{
        // CRUD -- Agent needs to be able to (menu options): 
            /*
               1. See all claims -- GET
               2. Take care of next claim in queue -- GET by ID? QUEUE?
               3. Enter a new claim -- CREATE
               4. Modify an existing claim -- UPDATE */
    public class ClaimRepository
    {
        // _listOfClaims Field
        //private List<Claim> _listOfClaims = new List<Claim>();
        private Queue<Claim> _queueOfClaims = new Queue<Claim>();

        // 3. CREATE -- enter new claim
        public void AddNewClaim(Claim newClaim)
        {
            _queueOfClaims.Enqueue(newClaim);
        }

        // 1. GET -- see all claims
        public Queue<Claim> GetAllClaims()
        {
            return _queueOfClaims;
        }

        //GET -- get next claim -- by ID(int)?
        public Claim GetClaimByIdNumber(int claimIdNumber)
        {
            foreach (Claim claim in _queueOfClaims)
            {
                if (claim.ClaimId == claimIdNumber)
                {
                    return claim;
                }
            }

            return null;
        }

        // GET -- claims queue
        public Queue<Claim> GetClaimsQueue()
        {
            return _queueOfClaims;
        }


        // 4. UPDATE -- modify existing claim
        public void UpdateExistingClaim(int originalClaim, Claim newClaim)
        {
            // Find original claim
            Claim oldClaim = GetClaimByIdNumber(originalClaim); 

            // Update claim
            if (oldClaim != null)
            {
                // assigning newClaim value to oldClaim value
                oldClaim.ClaimId = newClaim.ClaimId;
                oldClaim.TypeOfClaim = newClaim.TypeOfClaim;
                oldClaim.ClaimDescription = newClaim.ClaimDescription;
                oldClaim.ClaimAmount = newClaim.ClaimAmount;
                oldClaim.DateOfIncident = newClaim.DateOfIncident;
                oldClaim.DateOfClaim = newClaim.DateOfClaim;
                //oldClaim.ClaimIsValid = newClaim.ClaimIsValid;

                Console.WriteLine("Claim was updated successfully");
            }
            else
            {
                Console.WriteLine("Claim was not updated.");
            }
        }

    }
}
