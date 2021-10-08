using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]

    public class ExtractInventoryTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            ExtractInventory ei = new ExtractInventory();

            List<string[]> list1 = new List<string[]>();
            list1.Add(new string[] { "A1", "Potato Crisps", "3.05", "Chip" });
            list1.Add(new string[] { "A2", "Stackers", "1.45", "Chip" });
            list1.Add(new string[] { "A3", "Grain Waves", "2.75", "Chip" });
            list1.Add(new string[] { "A4", "Cloud Popcorn", "3.65", "Chip" });

        }
    }
}










