﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class HawaiianPizza:Pizza
    {
        string dough;
        string sauce;
        string topping;

        public HawaiianPizza(string topping, string dough, string sauce)    
        {
            this.topping = topping;
            this.dough = dough;
            this.sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("Your order is Hawaiian Pizza: " + Order());
        }

        public override string Order()
        {
            return ($"topping is {topping}, dough is {dough}, sauce is {sauce}. ");
        }
    }
}
