using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.IBehavior;

namespace StrategyPattern.Behavior
{
    public class DuckQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack,quack..");
    }
}
