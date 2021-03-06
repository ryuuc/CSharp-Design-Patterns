﻿namespace DecoratorPattern
{
    /// <summary>
    /// 调料
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
