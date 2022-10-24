using Factory.SimpleFactory.Factories;
using Factory.SimpleFactory.Pizzas;
using Factory.SimpleFactory.Pizzas.Abstractions;

namespace DesignPatternTests.SimpleFactory
{
    public class SimpleFactoryPatternTests
    {
        [Fact]
        public void CreatePizza_InvalidPizza_ShouldReturnNull()
        {
            var pizzaFactory = new SimplePizzaFactory();

            Pizza? pizza = pizzaFactory.Create("");

            Assert.Null(pizza);
        }

        [Fact]
        public void CreatePizza_CheesePizza_ShouldReturnCheesePizza()
        {
            var pizzaFactory = new SimplePizzaFactory();

            Pizza? pizza = pizzaFactory.Create("cheese");

            Assert.IsType<CheesePizza>(pizza);
        }

        [Fact]
        public void CreatePizza_VeggiePizza_ShouldReturnVeggiePizza()
        {
            var pizzaFactory = new SimplePizzaFactory();

            Pizza? pizza = pizzaFactory.Create("veggie");

            Assert.IsType<VeggiePizza>(pizza);
        }

    }
}
