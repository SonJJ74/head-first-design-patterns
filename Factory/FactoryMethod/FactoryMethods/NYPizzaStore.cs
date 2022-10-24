using Factory.FactoryMethod.FactoryMethods.Abstractions;
using Factory.FactoryMethod.Pizzas;
using Factory.FactoryMethod.Pizzas.Abstractions;

namespace Factory.FactoryMethod.FactoryMethods
{
    public sealed class NYPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string pizzaType)
        {
            Pizza? pizza = null;

            switch (pizzaType.ToLower())
            {
                case "cheese":
                    pizza = new NYCheesePizza();
                    break;
                case "veggie":
                    pizza = new NYVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
