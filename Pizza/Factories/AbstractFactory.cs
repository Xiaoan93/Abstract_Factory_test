using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public abstract class AbstractFactory
    {   
        private static SpicyFactory spicyFactory = new SpicyFactory();
        private static SpecialFactory specialFactory = new SpecialFactory();
        private static HawaiianFactory hawaiianPizza = new HawaiianFactory();
        public static AbstractFactory GetPizza(PizzaType type)
        {
            AbstractFactory? factory = null;
            switch (type)
            {
                case PizzaType.HawaiianPizza:
                    factory = hawaiianPizza;
                    break;
                case PizzaType.SpicyPizza:
                    factory = spicyFactory;
                    break;
                case PizzaType.SpecialPizza:
                    factory = specialFactory;
                    break;
                
            }
            return factory;
        }

        public abstract Pizza MakePizza(string topping, string dough, string sauce);
       
        
    }
}
