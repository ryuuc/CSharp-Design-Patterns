using System;

namespace FactoryPattern
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
            Dough = "ChicagoStyleVeggiePizza Dough";
            Sauce = "ChicagoStyleVeggiePizza Sauce";

            Toppings.Add("ChicagoStyleVeggiePizza Cheese");
        }

        internal override void Box() => Console.WriteLine("ChicagoStyleVeggiePizza Box");
    }
}
