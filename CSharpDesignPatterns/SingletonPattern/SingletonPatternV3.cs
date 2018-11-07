namespace SingletonPattern
{
    public class SingletonPatternV3
    {
        private volatile static SingletonPatternV3 _instance;
        private static readonly object _oLock = new object();

        private SingletonPatternV3() { }

        public static SingletonPatternV3 Instance()
        {
            if(_instance == null)
            {
                lock (_oLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonPatternV3();
                    }
                }
            }
            return _instance;
        }
    }
}
