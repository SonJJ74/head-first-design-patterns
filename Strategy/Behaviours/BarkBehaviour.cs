using Strategy.Behaviours.Abstractions;

namespace Strategy.Behaviours
{
    public class BarkBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
