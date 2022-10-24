using Factory.FactoryMethod.Pizzas.Abstractions;

namespace Factory.FactoryMethod.Pizzas
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
