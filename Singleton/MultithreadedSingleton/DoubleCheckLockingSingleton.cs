namespace Singleton.MultithreadedSingleton
{
    public class DoubleCheckLockingSingleton
    {
        private static DoubleCheckLockingSingleton? _uniqueInstance;
        private static readonly object _padLock = new();

        private DoubleCheckLockingSingleton()
        {
        }

        public static DoubleCheckLockingSingleton UniqueInstance
        {
            get
            {
                if (_uniqueInstance is null)
                {
                    lock (_padLock)
                    {
                        if (_uniqueInstance is null)
                        {
                            _uniqueInstance = new();
                        }
                    }
                }

                return _uniqueInstance;
            }
        }
    }
}
