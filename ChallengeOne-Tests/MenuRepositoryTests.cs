using System;
using System.Collections.Generic;
using ChallengeOne_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOne_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {

        private MenuRepository _repo;
        private Menu _menu;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _menu = new Menu(4, "Donut", "Chocolate-dipped", 1.50, "flour, chocolate");

            _repo.AddNewMenuItem(_menu);
        }

        // READ 
        [TestMethod]
        public void GetListOfMenuItems_ShouldGetAllMenuItems()    // Should get all menu items
        {
            // ARRANGE -- setup
            MenuRepository repo = new MenuRepository();
            Menu newMenu = new Menu(4, "Donut", "Chocolate-dipped", 1.50, "flour, chocolate");

            repo.AddNewMenuItem(newMenu);

            // ACT -- run code we want to test
            List<Menu> menu = repo.GetAllMenuItems();

            bool menuHasNewMenu = menu.Contains(newMenu);

            // ASSERT -- verify expected outcome
            Assert.IsTrue(menuHasNewMenu);
        }

        // READ/GET -- GET menu item by name 
        [TestMethod]
        public void GetMenuItemByName()     // Should get one specific menu item
        {
            // ARRANGE


            // ACT

            // ASSERT
        }

        // CREATE -- add menu item
        //[TestMethod]
        //public void AddNewMenuItemToList_ShouldAddMenuItem()      // Should add menu item
        //{
        //    ARRANGE


        //    ACT

        //     ASSERT
        //}

        // DELETE -- delete menu item
        [TestMethod]
        public void DeleteMenuItemByName_ShouldReturnTrue()            // Should return true
        {
            // Arrange
            // this will be replaced with our [TestInitialize] method
            Arrange();

            // Act
            bool delete = _repo.DeleteMenuItem("Donut");

            // Assert
            Assert.IsTrue(delete);
        }

        [DataTestMethod]
        [DataRow("Donut", true)]
        public void DeleteByName_ShouldReturnTrue(string menuItem, bool expectedResult)
        {
            // Arrange
            // this will be replaced with our [TestInitialize] method
            Arrange();

            // Act
            bool actualResult = _repo.DeleteMenuItem("Donut");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
