namespace DecoratorPattern
{
    /// <summary>
    /// 饮品
    /// </summary>
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        public abstract string Description { get; }

        public abstract double Cost();
    }
}
