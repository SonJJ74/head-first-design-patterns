using System;
using Decorator.Components.Abstractions;

namespace Decorator.Decorators.Abstractions
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}

