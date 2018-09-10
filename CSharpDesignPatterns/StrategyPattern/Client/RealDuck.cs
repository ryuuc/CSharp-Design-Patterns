using System;
using StrategyPattern.Abstact;
using StrategyPattern.Behavior;

namespace StrategyPattern.Client
{
    public class RealDuck : Duck
    {
        public RealDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new DuckQuack());
        }

        public override void Display()
        {
            Console.WriteLine("A real duck.");
        }
    }
}
