using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class InventoryMethods
    {
       public static void AdjustInventory(Dictionary<string, Snack> inventory, string itemSelected)
        {
            inventory[itemSelected].Quantity -= 1;
        }
        
    }
}
