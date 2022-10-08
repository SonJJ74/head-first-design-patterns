// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation.Observers;
using Observer.WeatherStation.Subjects;

Console.WriteLine("Hello, Observer Pattern!");

var weatherData = new WeatherData();

var forecastDisplay = new ForecastDisplay(weatherData);
var thirdPartyDisplay = new ThirdPartyDisplay(weatherData);
