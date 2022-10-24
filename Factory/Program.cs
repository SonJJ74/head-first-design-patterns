// See https://aka.ms/new-console-template for more information
using Factory.FactoryMethod.FactoryMethods;
using Factory.SimpleFactory.Factories;
using FactoryPizzaStore = Factory.FactoryMethod.FactoryMethods.Abstractions.PizzaStore;
using SimplePizzaStore = Factory.SimpleFactory.PizzaStore;

Console.WriteLine("Hello, Simple Factory Pattern!");

var pizzaSimpleFactory = new SimplePizzaFactory();
var pizzaSimpleStore = new SimplePizzaStore(pizzaSimpleFactory);

var cheesePizza = pizzaSimpleStore.OrderPizza("cheese");
Console.WriteLine($"We ordered a {cheesePizza?.Name}");

var veggiePizza = pizzaSimpleStore.OrderPizza("cheese");
Console.WriteLine($"We ordered a {veggiePizza?.Name}");
Console.WriteLine();

Console.WriteLine("Hello, Factory Method Pattern!");

FactoryPizzaStore nyPizzaFactoryStore = new NYPizzaStore();
var nyCheesePizza = nyPizzaFactoryStore.OrderPizza("cheese");
Console.WriteLine($"We ordered a {nyCheesePizza?.Name}");
var nyVeggiePizza = nyPizzaFactoryStore.OrderPizza("veggie");
Console.WriteLine($"We ordered a {nyVeggiePizza?.Name}");

FactoryPizzaStore chicagoPizzaFactoryStore = new NYPizzaStore();
var chicagoCheesePizza = chicagoPizzaFactoryStore.OrderPizza("cheese");
Console.WriteLine($"We ordered a {chicagoCheesePizza?.Name}");
var chicagoVeggiePizza = nyPizzaFactoryStore.OrderPizza("veggie");
Console.WriteLine($"We ordered a {chicagoVeggiePizza?.Name}");
