namespace SingletonPattern
{
    public class SingletonPatternV2
    {
        private static SingletonPatternV2 _instance = new SingletonPatternV2();

        private SingletonPatternV2() { }

        public static  SingletonPatternV2 Instance()
        {
            return _instance;
        }
    }
}
