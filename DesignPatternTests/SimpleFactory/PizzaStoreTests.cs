using Factory.SimpleFactory.Pizzas.Abstractions;
using Factory.SimpleFactory.Factories;

namespace DesignPatternTests.SimpleFactory
{
    public class PizzaStoreTests
    {
        [Fact]
        public void PizzaStore_OrderPizza_ShouldReturnTypeOfPizza()
        {
            var pizzaFactory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(pizzaFactory);

            var pizza = pizzaStore.OrderPizza("cheese");

            Assert.IsAssignableFrom<Pizza?>(pizza);
        }

        [Fact]
        public void PizzaStore_OrderPizza_ShouldReturnChosenPizza()
        {
            var pizzaFactory = new SimplePizzaFactory();
            var pizzaStore = new PizzaStore(pizzaFactory);

            var pizza = pizzaStore.OrderPizza("veggie");

            Assert.IsAssignableFrom<Pizza?>(pizza);
        }
    }
}
