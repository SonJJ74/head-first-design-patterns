namespace Singleton.MultithreadedSingleton
{
    public class StandardSingleton
    {
        //NOTE: this is not thread safe
        private static StandardSingleton? _uniqueInstance;

        private StandardSingleton()
        {
        }

        public static StandardSingleton UniqueInstance =>
            _uniqueInstance ?? (_uniqueInstance = new());
    }
