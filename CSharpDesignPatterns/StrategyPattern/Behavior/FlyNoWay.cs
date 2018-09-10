using System;
using StrategyPattern.IBehavior;

namespace StrategyPattern.Behavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I Can't fly.");
    }
}
