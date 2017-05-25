﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Beverage: VendableItem
    {
      
        public override string Consume()
        {
            return "Glug, Glug, YUM!";
        }
        public Beverage(decimal price, string name)
        {
            base.price = price;
            base.name = name;
        }
    }
}
