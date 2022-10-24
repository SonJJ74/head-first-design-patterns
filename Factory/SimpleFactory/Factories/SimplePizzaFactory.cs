using Factory.SimpleFactory.Pizzas;
using Factory.SimpleFactory.Pizzas.Abstractions;

namespace Factory.SimpleFactory.Factories
{
    //This could be a static simple factory
    public class SimplePizzaFactory
    {
        public Pizza? Create(string pizzaType)
        {
            Pizza? pizza = null;

            switch (pizzaType.ToLower())
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}
