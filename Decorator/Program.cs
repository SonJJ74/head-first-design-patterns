// See https://aka.ms/new-console-template for more information
using Decorator.Components;
using Decorator.Components.Abstractions;
using Decorator.Decorators;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Decorator Pattern!");

        //Be aware of the type
        Beverage firstBeverage = new HouseBlend();
        ReadBeverage(firstBeverage);

        Beverage secondBeverage = new DarkRoast();
        secondBeverage = new Sugar(secondBeverage);
        ReadBeverage(secondBeverage);
        secondBeverage = new Milk(secondBeverage);
        ReadBeverage(secondBeverage);
        secondBeverage = new Whip(secondBeverage);
        ReadBeverage(secondBeverage);
    }

    private static void ReadBeverage(Beverage beverage) =>
        Console.WriteLine(@$"Drink: {beverage.Description}, Cost: {Math.Round(beverage.Cost(), 2)}");
}
