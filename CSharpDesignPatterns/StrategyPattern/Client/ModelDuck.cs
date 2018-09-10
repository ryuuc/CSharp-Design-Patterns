using System;
using StrategyPattern.Abstact;
using StrategyPattern.Behavior;

namespace StrategyPattern.Client
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }

        public override void Display() => Console.WriteLine("A model duck.");
    }
}
