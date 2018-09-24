using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Claims Claims { get; set; }


        public abstract void Prepare();

        public virtual void Bake() => Console.WriteLine("Bake for 25 minutes for 350.");
        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices.");
        public virtual void Box() => Console.WriteLine("Place pizza in offical PizzaStore box.");

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
