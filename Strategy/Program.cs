using Strategy.Behaviours;
using Strategy.Dogs;

Console.WriteLine("This is to demonstrate the 'Strategy Pattern'");

//Dynamically set the behaviour at run time
var labrador = new Labrador();
labrador.ReadDogTag();
labrador.PerformBark();
labrador.SetBarkBehavior(new MuteBehaviour());
labrador.SetMovementBehaviour(new WalkBehaviour());
labrador.PerformBark();
labrador.PerformMovement();

var husky = new Husky();
husky.ReadDogTag();
husky.SetBarkBehavior(new HowlBehaviour());
husky.SetMovementBehaviour(new RunBehaviour());
husky.PerformBark();
husky.PerformMovement();
