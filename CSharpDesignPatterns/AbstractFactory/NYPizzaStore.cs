using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(pizzaIngredientFactory)
                    {
                        Name = "New York Style Cheese Pizza"
                    };
                    break;
                case "veggie":
                    pizza =new VeggiePizza(pizzaIngredientFactory);
                default:
                    throw new NotImplementedException($"DO NOT Provide {type} ");
            }
        }
    }
}
