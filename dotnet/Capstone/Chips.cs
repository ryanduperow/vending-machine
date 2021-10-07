using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chips : Snack
    {
        public Chips(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string MessageDisplay()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
