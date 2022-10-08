using Strategy.Behaviours.Abstractions;

namespace Strategy.Behaviours
{
    public class HowlBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Console.WriteLine("Howl");
        }
    }
}
