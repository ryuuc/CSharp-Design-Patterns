using System;
using StrategyPattern.IBehavior;

namespace StrategyPattern.Behavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Can't quack.");
    }
}
