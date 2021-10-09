using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExtractInventory ei = new ExtractInventory();
            Dictionary<string, Snack> testDic = new Dictionary<string, Snack>();
            testDic = ei.ReadInventoryFile();

            Dictionary<string, int> emptyReport = InventoryMethods.CreateBlankReport(testDic);


            VendingMachine vm = new VendingMachine(testDic, emptyReport);
            vm.MainMenu();


        }
    }
}
