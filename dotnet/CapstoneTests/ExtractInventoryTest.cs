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

            list1.Add("A1", "Potato Crisps", "3.05", "Chip");


            ei.ReadInventoryFile

        }
    }
}
