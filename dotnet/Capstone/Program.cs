using System;
using System.Collections.Generic;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string[]> list = new List<string[]>();
            list = ExtractInventory.ReadInventoryFile();
            foreach (string[] item in list)
            {
                Console.WriteLine(item[0]);
            }

        }
    }
}
