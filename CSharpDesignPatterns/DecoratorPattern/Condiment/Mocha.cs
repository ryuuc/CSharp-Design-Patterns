﻿namespace DecoratorPattern
{
    /// <summary>
    /// 摩卡
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ",Mocha";
        }

        public override double Cost()
        {
            return 0.20 + beverage.Cost();
        }
    }
}
