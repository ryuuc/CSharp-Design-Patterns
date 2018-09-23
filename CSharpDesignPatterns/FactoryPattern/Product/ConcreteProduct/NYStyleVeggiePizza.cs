using System;

namespace FactoryMethod
{
    internal class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "NYStyleVeggiePizza Dough";
            Sauce = "NYStyleVeggiePizza Sauce";

            Toppings.Add("NYStyleVeggiePizza Cheese");
        }

        internal override void Bake() => Console.WriteLine("NYStyleVeggiePizza Bake");
    }
}