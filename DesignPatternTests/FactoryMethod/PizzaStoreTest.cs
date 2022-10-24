using Factory.FactoryMethod.FactoryMethods;
using Factory.FactoryMethod.Pizzas.Abstractions;

namespace DesignPatternTests.FactoryMethod
{
    public class PizzaStoreTest
    {
        [Fact]
        public void CreatePizza_InvalidPizza_ShouldReturnNull()
        {
            var pizzaStore = new NYPizzaStore();

            Pizza? pizza = pizzaStore.CreatePizza("");

            Assert.Null(pizza);
        }

        [Fact]
        public void NYPizzaStore_CreatePizza_ValidPizza_ShouldReturnTypeOfPizza()
        {
            var pizzaStore = new NYPizzaStore();

            Pizza? pizza = pizzaStore.CreatePizza("cheese");

            Assert.IsAssignableFrom<Pizza?>(pizza);
        }

        [Fact]
        public void ChicagoPizzaStore_CreatePizza_ValidPizza_ShouldReturnTypeOfPizza()
        {
            var pizzaStore = new ChicagoPizzaStore();

            Pizza? pizza = pizzaStore.CreatePizza("cheese");

            Assert.IsAssignableFrom<Pizza?>(pizza);
        }
    }
}
