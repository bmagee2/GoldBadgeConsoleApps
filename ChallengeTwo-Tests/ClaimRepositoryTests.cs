using System;
using System.Collections.Generic;
using ChallengeTwo_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ChallengeTwo_Repository.Claim;

namespace ChallengeTwo_Tests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        private ClaimRepository _repo;
        private Claim _claim;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepository();
            // Id(int), Type(emun), Description(string), Amount(double), DateOfIncident(DateTime), DateOfClaim(DateTime)
            _claim = new Claim(4, ClaimType.Car, "car eaten by t-rex", 20000.00, new DateTime(1994, 12, 12), new DateTime(1993, 1, 12));

            _repo.AddNewClaim(_claim);
        }

        // READ 
        [TestMethod]
        public void GetAllClaims_ShouldGetAllClaims()    // Should get all menu items
        {
            // ARRANGE -- setup
            ClaimRepository repo = new ClaimRepository();
            Claim newClaim = new Claim(4, ClaimType.Car, "car eaten by t-rex", 20000.00, new DateTime(1994, 12, 12), new DateTime(1993, 1, 12));

            repo.AddNewClaim(newClaim);

            // ACT -- run code we want to test
            Queue<Claim> claim = repo.GetAllClaims();

            bool claimHasNewClaim = claim.Contains(newClaim);

            // ASSERT -- verify expected outcome
            Assert.IsTrue(claimHasNewClaim);
        }

        // DELETE -- delete menu item
        //[TestMethod]
        //public void DeleteMenuItemByName_ShouldReturnTrue()            // Should return true
        //{
        //    // Arrange
        //    // this will be replaced with our [TestInitialize] method
        //    Arrange();

        //    // Act
        //    bool delete = _repo.DeleteMenuItem("Donut");

        //    // Assert
        //    Assert.IsTrue(delete);
        //}

        //[DataTestMethod]
        //[DataRow("Donut", true)]
        //public void DeleteByName_ShouldReturnTrue(string menuItem, bool expectedResult)
        //{
        //    // Arrange
        //    // this will be replaced with our [TestInitialize] method
        //    Arrange();

        //    // Act
        //    bool actualResult = _repo.DeleteMenuItem("Donut");

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
