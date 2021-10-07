using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<string[]> list = new List<string[]>();
            list = ExtractInventory.ReadInventoryFile(Environment.CurrentDirectory, "vendingmachine.csv");
            foreach (string[] item in list)
            {
                foreach (string itemthing in item)
                {
                    Console.Write($"{itemthing} ");
                }
                Console.WriteLine();
            }

        }
    }
}
