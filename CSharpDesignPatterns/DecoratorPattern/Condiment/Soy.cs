using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// 豆浆
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return beverage.Description + ",Soy";
            }
        }

        public override double Cost()
        {
            return 0.10 + beverage.Cost();
        }
    }
}
