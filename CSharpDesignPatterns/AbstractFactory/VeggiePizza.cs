using System;

namespace AbstractFactory
{
    internal class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this._pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVeggies();
        }
    }
}