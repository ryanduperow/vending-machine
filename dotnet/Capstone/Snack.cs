﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
      public abstract class Snack : ISnackable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get;  set; }

        public abstract string MessageDisplay();
    }
}
