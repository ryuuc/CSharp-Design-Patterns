using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        internal string Name, Dough, Sauce;

        internal List<string> Toppings = new List<string>();

        internal void Prepare()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Preparing {Name}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tossing dough...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Adding topping: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Toppings.ForEach(x => Console.WriteLine($" {x}"));
        }

        internal virtual void Bake() => Console.WriteLine("Bake for 25 minutes for 350.");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices.");
        internal virtual void Box() => Console.WriteLine("Place pizza in offical PizzaStore box.");
    }
}
