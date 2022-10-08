// See https://aka.ms/new-console-template for more information
using Observer.WeatherStation.Observers;
using Observer.WeatherStation.Subjects;

Console.WriteLine("Hello, Observer Pattern!");

//Setup the subject/publisher
var weatherData = new WeatherData();

//Setup the observer(s)/subscriber(s)
var thirdPartyDisplay = new CurrentConditionsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(32.1, 65, 30.4);
weatherData.SetMeasurements(16, 32, 30.5);
