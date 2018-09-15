namespace DecoratorPattern
{
    /// <summary>
    /// 饮品
    /// </summary>
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";
        public string GetDescription() { return description; }

        public abstract double Cost();
    }
}
