// See https://aka.ms/new-console-template for more information
using Singleton.ChocolateBoiler;

Console.WriteLine("Hello, Singleton Pattern!");

var boiler = ChocolateBoiler.GetInstance();

boiler.Fill();
boiler.Boil();
boiler.Drain();

//This boiler should be the first boiler
var secondBoiler = ChocolateBoiler.GetInstance();
var isEmpty = boiler.IsEmpty;
var hasBoiled = boiler.HasBoiled;
