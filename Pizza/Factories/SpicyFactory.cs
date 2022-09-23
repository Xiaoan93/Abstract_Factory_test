using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class SpicyFactory: AbstractFactory
    {
        public override Pizza MakePizza(string topping, string dough, string sauce)
        {
            return new SpicyPizza(topping, dough, sauce);
        }

        
    }
}
