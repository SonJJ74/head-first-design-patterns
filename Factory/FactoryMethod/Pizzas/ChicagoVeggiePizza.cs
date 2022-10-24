using Factory.FactoryMethod.Pizzas.Abstractions;

namespace Factory.FactoryMethod.Pizzas
{
    public class ChicagoVeggiePizza : Pizza
    {
        public ChicagoVeggiePizza()
        {
            Name = "Chicago Deep Dish Veggie Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Black Olives");
            Toppings.Add("Spinach");
            Toppings.Add("Eggplant");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
