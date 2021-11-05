using KomodoBadges_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoBadges_TestMethods
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class BadgeTestMethods
    {
        public BadgeTestMethods()
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


        private BadgeRepo _badgeRepo;
        private Badge _badge;
        private Badge _badge2;


        [TestInitialize]
        public void Arrange()
        {
            _badgeRepo = new BadgeRepo();
            _badge = new Badge(987, "A7");
            _badge2 = new Badge(654, "B4");
            _badgeRepo.CreateNewBadge(_badge);

        }


        [TestMethod]
        public void CreateNewBadge()
        {
            bool wasAdded = _badgeRepo.CreateNewBadge(_badge2);

            Assert.IsTrue(wasAdded);
        }


        [TestMethod]
        public void UpdateDoorsForExistingBadge()
        {
            bool wasFound = _badgeRepo.UpdateDoorsForExistingBadge(_badge.BadgeID, _badge2);
            Assert.IsTrue(wasFound);
        }

        [TestMethod]
        public void RemoveDoorsFromExistingBadge()
        {
            bool wasRemoved = _badgeRepo.RemoveDoorsFromExistingBadge(_badge);
            Assert.IsTrue(wasRemoved);
        }






    }
}