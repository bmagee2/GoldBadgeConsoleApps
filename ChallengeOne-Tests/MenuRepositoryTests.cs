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

        //[TestInitialize]
        //public void Arrange()
        //{
        //    _repo = new StreamingContentRepository();
        //    _content = new StreamingContent("Clifford", "Dinosaur World", MovieRating.PG13, 10, 1994, Genre.Comedy);

        //    _repo.AddContentToDirectory(_content);
        //}

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _menu = new Menu(4, "Donut", "Chocolate-dipped", 1.50, "flour, chocolate");

            _repo.AddNewMenuItem(_menu);
        }

        // READ -- GET all items in the menu list
        [TestMethod]
        public void GetListOfMenuItems_ShouldGetAllMenuItems()    // Should get all menu items
        {
            // ARRANGE
            MenuRepository repo = new MenuRepository();
            Menu newMenu = new Menu(4, "Donut", "Chocolate-dipped", 1.50, "flour, chocolate");

            repo.AddNewMenuItem(newMenu);

            // ACT
            List<Menu> menu = repo.GetAllMenuItems();

            bool menuHasNewMenu = menu.Contains(newMenu);

            // ASSERT
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
        [TestMethod]
        public void AddNewMenuItemToList_ShouldAddMenuItem()      // Should add menu item
        {
            // ARRANGE


            // ACT

            // ASSERT
        }

        // DELETE -- delete menu item
        [TestMethod]
        public void DeleteMenuItem_ShouldReturnTrue()            // Should return true
        {
            // Arrange
            // this will be replaced with our [TestInitialize] method
            // Arrange()

            // Act
            //bool delete = _repo.DeleteExistingContent(_content);

            // Assert
            //Assert.IsTrue(delete);
        }
    }
}
