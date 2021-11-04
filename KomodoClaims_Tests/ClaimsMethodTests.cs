using KomodoClaims_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KomodoClaims_Tests
{
    [TestClass]
    public class ClaimsMethodTests
    {
        [TestMethod]
        public void Test_AddNewClaim()
        {

            ClaimsRepo _repo = new ClaimsRepo();
            Claims claim = new Claims();

         
            //List<Claims> list = _repo.SeeAllClaims();
            //int count = list.Count;
            //_repo.AddNewClaim(claim);
            //List<Claims> updatedList = _repo.SeeAllClaims();
            //int newCount = updatedList.Count;

            //bool result = newCount == (count + 1) ? true : false;


            //Assert.IsTrue(result);


        }

        public void Test_GetClaimByClaimID()
        {
            ClaimsRepo _repo = new ClaimsRepo();
            Claims claim = new Claims();

            //List<Claims> claimID = _repo.SeeAllClaims();
            //_repo.GetClaimByClaimID(Convert.ToInt32(claimID));

            //bool result = claimID == claimID ? true : false;

        }

        public void Test_UpdateExistingClaim()
        {

        }
    }
}
