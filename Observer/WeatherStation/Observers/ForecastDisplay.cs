using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _currentPressure = 29.92d;
        private double _lastPressure;
        private readonly ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(
            double temperature,
            double humidity,
            double pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            var displayMessage = true switch
            {
                true when _currentPressure > _lastPressure =>
                    "Improving weather on the way",
                true when _currentPressure == _lastPressure =>
                    "The weather is going to be the same",
                true when _currentPressure < _lastPressure => 
                    "The weather is going to be cooler & rainer",
                _ => 
                    "Unknown weather conditions"
            };

            Console.WriteLine(displayMessage);
        }
    }
}
