using Strategy.Behaviours.Abstractions;

namespace Strategy.Behaviours
{
    public class WalkBehaviour : IMovementBehaviour
    {
        public void Move()
        {
            Console.WriteLine("Walk");
        }
    }
}
