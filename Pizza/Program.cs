

namespace Pizza
{
    public class Program
    {
        public static void Main()
        {
            char ans;
            do
            {
                int choice;
                do
                {
                    Console.WriteLine("Please choose your Pizza Option : ");
                    Console.WriteLine("1. Hawaiian Pizza.");
                    Console.WriteLine("2. Spicy Pizza.");
                    Console.WriteLine("3. Special Pizza.");
                } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

                switch (choice)
                {

                    case 1:
                        AbstractFactory factory = AbstractFactory.GetPizza(PizzaType.HawaiianPizza);
                        Pizza hawaiian = factory.MakePizza("Ham + Pineapple", "Cross", "Mild");
                        hawaiian.Display();
                        break;

                    case 2:
                        AbstractFactory factory2 = AbstractFactory.GetPizza(PizzaType.SpicyPizza);
                        Pizza spicy = factory2.MakePizza("Pepporoni + Salami", "Baked", "Hot");
                        spicy.Display();
                        break;

                    case 3:
                        AbstractFactory factory3 = AbstractFactory.GetPizza(PizzaType.SpecialPizza);
                        Pizza special = factory3.MakePizza("Meat + Saucisse", "Special Baked", "Sweet");
                        special.Display();
                        break;
                }

                Console.WriteLine("Do you want to choose again ? (Y/N) ");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y' || ans == 'Y');
            
        }
    }
}
