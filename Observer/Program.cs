// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation.Observers;
using Observer.WeatherStation.Subjects;

Console.WriteLine("Hello, Observer Pattern!");

var weatherData = new WeatherData();

var statisticsDisplay = new StatisticsDisplay(weatherData);
var forecastDisplay = new StatisticsDisplay(weatherData);
var thirdPartyDisplay = new StatisticsDisplay(weatherData);
