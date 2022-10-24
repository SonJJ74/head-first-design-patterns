using Factory.SimpleFactory.Factories;
using Factory.SimpleFactory.Pizzas.Abstractions;

namespace Factory.SimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public Pizza? OrderPizza(string pizzaType)
        {
            var pizza = _pizzaFactory.Create(pizzaType);

            if (pizza is null)
            {
                return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}