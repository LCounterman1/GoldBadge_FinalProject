using KomodoClaims_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoClaims_Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ClaimsMethodsTest
    {
        public ClaimsMethodsTest()
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

        private ClaimsRepo _claimsRepo;
        private Claims _claim;
        private Claims _claim2;

        [TestInitialize]
        public void Arrange()
        {
            _claimsRepo = new ClaimsRepo();
            _claim = new Claims(123, ClaimType.Home, "Wind damage from storm", 5000.00, new DateTime(2020,05,17), new DateTime(2020,06,01));
            _claim2 = new Claims(456, ClaimType.Theft, "Stolen pillows from hotel room", 60.00, new DateTime(2020,06,19), new DateTime(2020,06,20));
        }




        [TestMethod]
        public void AddNewClaim()
        {
            bool wasAdded = _claimsRepo.AddNewClaim(_claim2);

            Assert.IsTrue(wasAdded);
        }
    }
}
