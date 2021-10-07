using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Chips : Snack
    {
        public Chips(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string MessageDisplay()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
