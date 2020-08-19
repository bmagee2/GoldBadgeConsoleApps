using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repository
{
    public class Claim
    {

        // CONSTRUCTORS
        public Claim() { }
        public Claim(int claimId, ClaimType typeOfClaim, string claimDescription, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimId = claimId;
            TypeOfClaim = typeOfClaim;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            //ClaimIsValid = claimIsValid;
        }

        // PROPERTIES of claim -- Id(int), Type(emun), Description(string), Amount(double), DateOfIncident(DateTime), DateOfClaim(DateTime), isValid(bool)
        public int ClaimId { get; set; } // need setter? look at example
        public ClaimType TypeOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool ClaimIsValid // Komodo allows an insurance claim to be made up to 30 days after an incident took place. If the claim is not in the proper time limit, it is not valid.
        {
            get
            {
                int days = ((TimeSpan)(DateOfClaim - DateOfIncident)).Days;
                Console.WriteLine(days);
                if (days > 30)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public enum ClaimType
        {
            Car = 1,
            Home,
            Theft
        }
    }
}
