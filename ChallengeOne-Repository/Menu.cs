using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repository
{
    // POCO -- single responsiblity object that holds data
    // test change
    public class Menu
    {
        //private string _listOfIngredients;
        // Menu Class with properties, constructors, and fields

        // CONSTRUCTORS
        public Menu() { }
        public Menu(int itemNumber, string itemName, string itemDescription, double itemPrice)
        // List<Ingredients> listOfIngredients
        //List<string> listOfIngredients)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemPrice = itemPrice;
            //ListOfIngredients = listOfIngredients;
        }

        // PROPERTIES -- of menu items -- number (int), name (string), description (string), list of ingredients (list or enum?), price (decimal)
        public int ItemNumber { get; set; } // NO SETTER FOR ITEM NUMBER?
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        // LIST OF INGREDIENTS -- how to set up a List property or field?
        //public List<string> ListOfIngredients { get; set; }
        //public List<Ingredients> ListOfIngredients { get; set; }

       
    }

    //public class Ingredients 
    //{
    //    public Ingredients(string ingredient)
    //    {
    //        Ingredient = ingredient;
    //    }
    //    public string Ingredient { get; set; }
    //}
    

}
