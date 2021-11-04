using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_ClassLibrary
{
    public class MenuRepo
    {
        protected readonly List<Menu> _menuList = new List<Menu>();
        

        public bool AddItemToMenu(Menu item)
        {
            int startingCount = _menuList.Count;
            _menuList.Add(item);
            bool wasAdded = _menuList.Count > startingCount ? true : false;
            return wasAdded;
    
        }
        
        public Menu GetMealByMealName(string mealName)
        {
            foreach (Menu item in _menuList)
            {
                if (item.MealName.ToLower() == mealName.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
        public List<Menu> GetAllItems()
        {
            return _menuList;
        }

        public bool DeleteItemFromMenu(Menu existingItem)
        {
            int startingCount = _menuList.Count;
            _menuList.Remove(existingItem);
            bool wasDeleted = _menuList.Count < startingCount ? true : false;
            return wasDeleted;
        }
    }

}
