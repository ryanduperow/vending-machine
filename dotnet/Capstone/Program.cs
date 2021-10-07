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

            foreach (KeyValuePair<string, Snack> dic in testDic)
            {
                Console.WriteLine($"{dic.Key} has {dic.Value.Quantity} {dic.Value.Name}s at {dic.Value.Price}");
            }


        }
    }
}
