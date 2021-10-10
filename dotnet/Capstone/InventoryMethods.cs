using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class InventoryMethods
    {
        //public static void AdjustInventory(Dictionary<string, Snack> inventory, string itemSelected)
        //{
        //    inventory[itemSelected].Quantity -= 1;
        //}

        public static Dictionary<string, int> CreateBlankReport(Dictionary<string, Snack> inventory)
        {

            Dictionary<string, int> emptyReport = new Dictionary<string, int>();

            foreach (KeyValuePair<string, Snack> item in inventory)
            {
                emptyReport.Add(item.Value.Name, 0);
            }
            return emptyReport;
        }

    }
}
