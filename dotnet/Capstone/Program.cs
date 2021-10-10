using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InventoryMethods im = new InventoryMethods();

            //create usable inventory and blank sales report form from external inventory file
            Dictionary<string, Snack> inventory = im.ReadInventoryFile();
            Dictionary<string, int> emptyReport = im.CreateBlankReport(inventory);


            VendingMachine vm = new VendingMachine(inventory, emptyReport);
            vm.MainMenu();


        }
    }
}
