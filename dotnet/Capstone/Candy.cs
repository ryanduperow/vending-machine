using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Candy: Snack
    {
        public Candy(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string MessageDisplay()
        {
            return "Munch Munch, Yum!";
        }
    }
}
