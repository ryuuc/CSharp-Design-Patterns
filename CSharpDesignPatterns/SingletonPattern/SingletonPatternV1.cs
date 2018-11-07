namespace SingletonPattern
{
    public class SingletonPatternV1
    {
        private static SingletonPatternV1 _instance;

        private SingletonPatternV1() { }

        public static SingletonPatternV1 Instance()
        {   
            return _instance ?? new SingletonPatternV1();
        }
    }
}
