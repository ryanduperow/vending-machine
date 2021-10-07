using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Beverage : Snack
    {
        public Beverage (string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string MessageDisplay()
        {
            return "Glug Glug, Yum!";
        }
    }
}