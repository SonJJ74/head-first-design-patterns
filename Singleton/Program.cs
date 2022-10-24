// See https://aka.ms/new-console-template for more information
using Singleton.ChocolateBoiler;

Console.WriteLine("Hello, Singleton Pattern!");

var boiler = ChocolateBoiler.UniqueInstance;

boiler.Fill();
boiler.Boil();
boiler.Drain();

//This boiler should be the first boiler
var secondBoiler = ChocolateBoiler.UniqueInstance;
var isEmpty = boiler.IsEmpty;
var hasBoiled = boiler.HasBoiled;
