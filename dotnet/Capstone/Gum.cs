using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Gum: Snack
    {
        public Gum(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string MessageDisplay()
        {
            return "Chew Chew, Yum!";
        }
    }
}
