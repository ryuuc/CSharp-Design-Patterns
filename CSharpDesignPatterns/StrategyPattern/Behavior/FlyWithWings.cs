using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.IBehavior;

namespace StrategyPattern.Behavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("Fly with wings");
        
    }
}
