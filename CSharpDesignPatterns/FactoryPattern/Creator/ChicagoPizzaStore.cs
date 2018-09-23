using System;

namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
                default:
                    throw new NotImplementedException($"DO NOT Provide {type} ");
            }
        }
    }
}
