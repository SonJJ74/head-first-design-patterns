using Factory.FactoryMethod.Pizzas.Abstractions;

namespace Factory.FactoryMethod.FactoryMethods.Abstractions
{
    public abstract class PizzaStore
    {
        protected abstract Pizza? CreatePizza(string pizzaType);

        public Pizza? OrderPizza(string pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            if(pizza is null)
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
