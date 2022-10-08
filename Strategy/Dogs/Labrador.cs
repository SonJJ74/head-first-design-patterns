using Strategy.Dogs.Abstractions;

namespace Strategy.Dogs
{
    public class Labrador : Dog
    {
        public override void ReadDogTag()
        {
            Console.WriteLine("The dog tag is for 'Zed'");
        }
    }
}
