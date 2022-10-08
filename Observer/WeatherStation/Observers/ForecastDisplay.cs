using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
