using Strategy.Dogs.Abstractions;

namespace Strategy.Dogs
{
    public class Husky : Dog
    {
        public override void ReadDogTag()
        {
            Console.WriteLine("The dog tag is for 'Ash'");
        }
    }
}
