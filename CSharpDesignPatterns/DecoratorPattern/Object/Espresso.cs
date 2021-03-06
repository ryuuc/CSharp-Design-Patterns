﻿namespace DecoratorPattern
{
    /// <summary>
    /// 浓咖啡
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override string Description => description;

        public override double Cost() { return 1.99; }
    }
}
