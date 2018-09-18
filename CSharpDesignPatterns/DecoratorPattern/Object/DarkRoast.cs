namespace DecoratorPattern
{
    /// <summary>
    /// 焦炒咖啡
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast() { description = "DarkRoast"; }

        public override string Description => description;

        public override double Cost()
        {
            return 1.99;
        }
    }
}
