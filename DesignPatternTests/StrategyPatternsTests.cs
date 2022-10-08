using Newtonsoft.Json;
using Strategy.Behaviours;
using Strategy.Dogs;

namespace DesignPatternTests
{
    public class StrategyPatternsTests
    {
        [Fact]
        public void Husky_MovementBehaviour_IsNull()
        {
            var husky = new Husky();

            Assert.Null(husky.MovementBehaviour);
        }

        [Fact]
        public void Husky_SetMovementBehaviour_EqualsWalkBehaviour()
        {
            var husky = new Husky();
            var expectedHuskyMovementBehaviour = new WalkBehaviour();

            husky.SetMovementBehaviour(new WalkBehaviour());
            var serializedExpectedMovement =
                JsonConvert.SerializeObject(expectedHuskyMovementBehaviour);
            var serializedHuskyMovement =
                JsonConvert.SerializeObject(husky.MovementBehaviour);

            Assert.Equal(serializedExpectedMovement, serializedHuskyMovement);
        }

        [Fact]
        public void Husky_BarkBehaviour_DefaultIsBarkBehaviour()
        {
            var husky = new Husky();
            var expectedBarkBehaviour = new BarkBehaviour();

            var serializedExpectedBark =
                JsonConvert.SerializeObject(expectedBarkBehaviour);
            var serializedHuskyBark =
                JsonConvert.SerializeObject(husky.BarkBehaviour);

            Assert.Equal(serializedExpectedBark, serializedHuskyBark);
        }

        [Fact]
        public void Husky_SetBarkBehaviour_EqualsHowlBehaviour()
        {
            var husky = new Husky();
            var expectedBarkBehaviour = new HowlBehaviour();

            husky.SetBarkBehavior(new HowlBehaviour());
            var serializedExpectedBark =
                JsonConvert.SerializeObject(expectedBarkBehaviour);
            var serializedHuskyBark =
                JsonConvert.SerializeObject(husky.BarkBehaviour);

            Assert.Equal(serializedExpectedBark, serializedHuskyBark);
        }
    }
}
