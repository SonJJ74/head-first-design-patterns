namespace Singleton.ChocolateBoiler
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler? _uniqueInstance;

        private ChocolateBoiler()
        {
            IsEmpty = true;
            HasBoiled = false;
        }

        public static ChocolateBoiler UniqueInstance
        {
            get
            {
                _uniqueInstance ??= new ChocolateBoiler();

                return _uniqueInstance;
            }
        }

        public bool IsEmpty { get; private set; }

        public bool HasBoiled { get; private set; }

        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
                HasBoiled = false;
                //todo: add code to fill the boiler with a milk/chocolate mixture
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !HasBoiled)
            {
                //todo: bring the contents to a boil
                HasBoiled = true;
            }
        }

        public void Drain()
        {
            if (!IsEmpty && HasBoiled)
            {
                //todo: drain the boiled milk and chocolate
                IsEmpty = true;
            }
        }
    }
}
