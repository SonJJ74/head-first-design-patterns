namespace Singleton.MultithreadedSingleton
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? _uniqueInstance;
        private static readonly object _padLock = new();

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton UniqueInstance
        {
            get
            {
                lock (_padLock)
                {
                    if (_uniqueInstance is null)
                    {
                        _uniqueInstance = new();
                    }
                }

                return _uniqueInstance;
            }
        }
    }
}
