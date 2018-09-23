using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYPizzaStore:PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                default:
                    throw new NotImplementedException($"DO NOT Provide {type} ");
            }
        }
    }
}
