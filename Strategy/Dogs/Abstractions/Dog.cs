using Strategy.Behaviours;
using Strategy.Behaviours.Abstractions;

namespace Strategy.Dogs.Abstractions
{
    public abstract class Dog
    {
        public IMovementBehaviour? MovementBehaviour { get; private set; }

        public IBarkBehaviour BarkBehaviour { get; private set; } = new BarkBehaviour();

        public abstract void ReadDogTag();

        //You could use the constructor in the subclasses to set the behaviour(s) statically
        public void SetMovementBehaviour(IMovementBehaviour movementBehaviour)
        {
            MovementBehaviour = movementBehaviour;
        }

        public void SetBarkBehavior(IBarkBehaviour barkBehaviour)
        {
            BarkBehaviour = barkBehaviour;
        }

        public void PerformMovement()
        {
            MovementBehaviour?.Move();
        }

        public void PerformBark()
        {
            BarkBehaviour.Bark();
        }
    }
}
