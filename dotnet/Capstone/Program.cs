using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExtractInventory ei = new ExtractInventory();

            //create usable inventory and blank sales report form from external inventory file
            Dictionary<string, Snack> testDic = ei.ReadInventoryFile();
            Dictionary<string, int> emptyReport = InventoryMethods.CreateBlankReport(testDic);


            VendingMachine vm = new VendingMachine(testDic, emptyReport);
            vm.MainMenu();


        }
    }
}
