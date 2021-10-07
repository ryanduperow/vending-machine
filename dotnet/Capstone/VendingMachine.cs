using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public void SelectSnack()
        {
            Output op = new Output();
            ExtractInventory ei = new ExtractInventory();
            Input ip = new Input();

            Dictionary<string, Snack> inventory = ei.ReadInventoryFile();
            op.DisplayInventory(inventory);

            string itemSelected = ip.GetMenuInput();

            if (!inventory.ContainsKey(itemSelected))
            {
                Console.WriteLine("Item does not exist!"); // TODO: Need to go back to purchase menu

            }
            else if (inventory[itemSelected].Quantity == 0)
            {
                Console.WriteLine("Item is sold out!");
            }
            else
            {
                Console.WriteLine($"{inventory[itemSelected].MessageDisplay()}");
            }          
        }

    }
}
