using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repository
{
    // Repo -- manipulator & holder of data (menu items)
    // CRUD -- don't need to be able to update items
    class MenuRepository
    {
        // FIELD -- class level variable that can be used everywhere (in every CRUD method)
        private List<Menu> _listOfMenuItems = new List<Menu>();

        // CREATE -- add menu item
        public void AddMenuItem(Menu menuItem)
        {
            _listOfMenuItems.Add(menuItem);
        }

        // READ -- GET all items in the menu list
        public List<Menu> GetMenuItems()
        {
            return _listOfMenuItems;
        }

        // READ/GET -- GET menu item by name (to delete)
        public Menu GetMenuItemByName(string menuItemName)
        {
            foreach (Menu item in _listOfMenuItems)
            {
                if (item.ItemName == menuItemName)
                {
                    return item;
                }
            }

            return null;
        }

        // DELETE -- delete menu item
        public bool DeleteMenuItem(string itemName) // OR (Menu menuItem)
        {
            Menu item = GetMenuItemByName(itemName);
            if (item == null)
            {
                return false;
            }

            bool itemDeleted = _listOfMenuItems.Remove(item);
            if (itemDeleted == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
