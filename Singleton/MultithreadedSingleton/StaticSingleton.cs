namespace Singleton.MultithreadedSingleton
{
    public class StaticSingleton
    {
        private static readonly StaticSingleton _uniqueInstance = new();

        private StaticSingleton()
        {
        }

        public static StaticSingleton UniqueInstance { get; } = _uniqueInstance;
    }
}
