using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(
            double temperature,
            double humidity,
            double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            var displayMesssage = @$"Current conditions, 
temperature: {_temperature} °C,
humdity: {_humidity}";

            Console.WriteLine(displayMesssage);
        }
    }
}
