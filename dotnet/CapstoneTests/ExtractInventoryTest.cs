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
            InventoryMethods im = new InventoryMethods();
            
            string directory = Environment.CurrentDirectory;
            string fileName = "test-1.txt";

            Dictionary<string, Snack> expected = new Dictionary<string, Snack>();
            expected["A1"] = new Chip("Potato Crisps", 3.05M);
            expected["A2"] = new Capstone.Chip("Stackers", 1.45M);
            expected["A3"] = new Capstone.Chip("Grain Waves", 2.75M);
            expected["A4"] = new Capstone.Chip("Cloud Popcorn", 3.65M);                       

            Dictionary<string, Snack> actual = im.ReadInventoryFile(directory, fileName);

            

            CollectionAssert.ReferenceEquals(expected, actual);
        }
    }
}










