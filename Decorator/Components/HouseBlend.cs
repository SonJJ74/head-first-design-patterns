using System;
using Decorator.Components.Abstractions;
using Decorator.Decorators;

namespace Decorator.Components
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
