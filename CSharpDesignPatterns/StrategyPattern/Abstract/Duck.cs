using System;
using StrategyPattern.IBehavior;

namespace StrategyPattern.Abstact
{
    public abstract class Duck
    {
        IFlyBehavior _flyBehavoir;
        IQuackBehavior _quackBehavoir;

        public void SetFlyBehavior(IFlyBehavior flyBehavior) => _flyBehavoir = flyBehavior;
        public void SetQuackBehavior(IQuackBehavior quackBehavior) => _quackBehavoir = quackBehavior;

        public abstract void Display();

        public void PerformFly() => _flyBehavoir.Fly();

        public void PerformQuack() => _quackBehavoir.Quack();

        public void Swim() => Console.WriteLine("All ducks float,even decoys!");
    }
}
