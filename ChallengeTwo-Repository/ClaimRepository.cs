using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repository
{
        // CRUD -- Agent needs to be able to (menu options): 
            /*
               1. See all claims -- GET
               2. Take care of next claim in queue -- GET by ID?
               3. Enter a new claim -- CREATE
               4. Modify an existing claim -- UPDATE */
    public class ClaimRepository
    {
        // _listOfClaims Field
        private List<Claim> _listOfClaims = new List<Claim>();

        // CREATE -- enter new claim
        public void AddNewClaim(Claim newClaim)
        {
            _listOfClaims.Add(newClaim);
        }

        // GET -- see all claims
        public List<Claim> GetAllClaims()
        {
            return _listOfClaims;
        }

        // GET -- get next claim


        // UPDATE -- modify existing claim
    }
}
