using KomodoCafe_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KomodoCafe_UnitTest
{
    

    private MenuRepo _repo;
    private Menu _menu;

    [TestInitialize]
    public void Arrange()
    {
        _repo = new MenuRepo();
    }


    [TestClass]
    public class MenuMethodTests
    {
        [TestMethod]
        public void Test_AddItemToMenu()
        {
            ///AAA
            //ARANGE - Setting up test data required to test our method. What do I need
            // to test this methong?

            MenuRepo _repo = new MenuRepo();
            Menu menu = new Menu();

            //ACT - calling our method and saving what it returns (if anything) to a variable

            List<Menu> list = _repo.GetAllItems();
            int count = list.Count;
            _repo.AddItemToMenu(menu);

            bool result = count == (count + 1) ? true : false;

            //ASSERT - 

            Assert.IsTrue(result);

        }

        public void Test_GetMealByMealName()
        {
            //not done
            MenuRepo _repo = new MenuRepo();
            Menu menu = new Menu();

            List<Menu> list = _repo.GetAllItems();
            //string mealName = list.GetType;
            //_repo.GetMealByMealName(mealName);

            //bool result = mealName == mealName ? true : false;

        }

        public void Test_GetAllItems()
        {
            MenuRepo _repo = new MenuRepo();
            Menu menu = new Menu();

            List<Menu> list = _repo.GetAllItems();
            //not done
        }

        public void Test_DeleteItemFromMenu()
        {

            MenuRepo _repo = new MenuRepo();
            Menu menu = new Menu();

            List<Menu> list = _repo.GetAllItems();
            int count = list.Count;
            _repo.DeleteItemFromMenu(menu);

            bool result = count == (count - 1) ? true : false;

            Assert.IsTrue(result);
        }
    }
}
