using System;
using Decorator.Components.Abstractions;
using Decorator.Decorators.Abstractions;

namespace Decorator.Decorators
{
    public class Sugar : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Sugar(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description =>
            _beverage.Description + ", Sugar";

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}
