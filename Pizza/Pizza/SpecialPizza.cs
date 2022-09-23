using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class SpecialPizza:Pizza
    {
        string topping;
        string dough;
        string sauce;

        public SpecialPizza( string topping, string dough, string sauce)
        {
            this.topping = topping;
            this.dough = dough;
            this.sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("Your order is Special Pizza: " + Order()) ;
        }

        public override string Order()
        {
            return ($"topping is {topping}, dough is {dough}, sauce is {sauce}.");
        }
    }
}
