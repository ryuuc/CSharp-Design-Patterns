using System;
using StrategyPattern.Abstact;
using StrategyPattern.Behavior;
using StrategyPattern.Client;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck real = new RealDuck();
            real.Display();
            real.PerformFly();
            real.PerformQuack();

            real.SetFlyBehavior(new FlyNoWay());
            real.PerformFly();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.PerformQuack();

            model.SetQuackBehavior(new DuckQuack());
            model.PerformQuack();

            Console.Read();
        }
    }
}
