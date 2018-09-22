using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan orderd  a {pizza.Name} .");
                       

            Console.WriteLine("-------------------------");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Joel orderd an {pizza.Name}.");

            Console.Read();
        }
    }
}
