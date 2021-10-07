using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Input
    {
        public string GetMenuInput()
        {
            string input = Console.ReadLine();
            return input;
        }

        public decimal GetMoney()
        {
            string input = Console.ReadLine();
            decimal money = Decimal.Parse(input);
            return money;
        }

        public string GetProduct()
        {
            Console.WriteLine("Please select item");
            string input = Console.ReadLine();
            return input;
        }
    }
}
