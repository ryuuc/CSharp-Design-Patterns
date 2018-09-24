using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Claims CreateClaims()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
