using KomodoCafe_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoCafe_UnitTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class MenuMethodsTest
    {
        public MenuMethodsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private MenuRepo _menuRepo;
        private Menu _item;
        private Menu _item2;


        [TestInitialize]
        public void Arrange()
        {
            _menuRepo = new MenuRepo();
            _item = new Menu(1, "BELT", "Crispy bacon, freid egg, fresh lettuce and juicy tomato placed between two slices of toasted wheat bread lightly spread with mayo", 4.99, "bacon, egg, lettuce, tomato, wheat bread, mayo");
            _item2 = new Menu(5, "Beef and Cheddar", "Roast beef smothered in a smokey cheddar sauce served on a brioche bun", 5.69, "roast beef, smokey cheddar cheese, brioche bun");
            _menuRepo.AddItemToMenu(_item);
        }



        [TestMethod]
        public void AddItemToMenu()
        {
            bool wasAdded = _menuRepo.AddItemToMenu(_item2);

            Assert.IsTrue(wasAdded);
        }

        [TestMethod]
        public void DeleteItemFromMenu()
        {
            bool wasRemoved = _menuRepo.DeleteItemFromMenu(_item);
            Assert.IsTrue(wasRemoved);
        }




    }
}
