using Strategy.Behaviours.Abstractions;

namespace Strategy.Behaviours
{
    public class MuteBehaviour : IBarkBehaviour
    {
        public void Bark()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
