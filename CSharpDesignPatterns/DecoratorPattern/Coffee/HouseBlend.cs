namespace DecoratorPattern
{
    /// <summary>
    /// 综合咖啡
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend() { description = "House Blend Coffee"; }

        public override string Description => description;

        public override double Cost() { return 0.89; }
    }
}
