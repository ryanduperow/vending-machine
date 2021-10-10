using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
   
    public class AccountingTests
    {
        [TestMethod]
        public void FeedMoneyTest()
        {
            Capstone.Accounting ac = new Capstone.Accounting();

            decimal balance = 4;
            decimal amountFed = 4;

            decimal expected = 8;
            decimal actual = ac.FeedMoney(balance, amountFed);

            Assert.AreEqual(expected, actual);

        }
    }
}
