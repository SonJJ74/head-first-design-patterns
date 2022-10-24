using Factory.FactoryMethod.FactoryMethods.Abstractions;
using Factory.FactoryMethod.Pizzas;
using Factory.FactoryMethod.Pizzas.Abstractions;

namespace Factory.FactoryMethod.FactoryMethods
{
    public sealed class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza? CreatePizza(string pizzaType)
        {
            Pizza? pizza = null;

            switch (pizzaType.ToLower())
            {
                case "cheese":
                    pizza = new ChicagoCheesePizza();
                    break;
                case "veggie":
                    pizza = new ChicagoVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
