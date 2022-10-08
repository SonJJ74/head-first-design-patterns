using Strategy.Behaviours.Abstractions;

namespace Strategy.Behaviours
{
    public class RunBehaviour : IMovementBehaviour
    {
        public void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
