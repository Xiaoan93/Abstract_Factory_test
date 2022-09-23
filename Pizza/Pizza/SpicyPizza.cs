using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class SpicyPizza:Pizza
    {
        string topping;
        string sauce;
        string dough;

        public SpicyPizza(string topping, string sauce, string dough)
        {
            this.topping = topping;
            this.dough = dough;
            this.sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("Your order is Spicy Pizza: " + Order());
        }

        public override string Order()
        {
            return ($"topping is {topping}, dough is {dough}, sauce is {sauce}.");
        }
    }
}
