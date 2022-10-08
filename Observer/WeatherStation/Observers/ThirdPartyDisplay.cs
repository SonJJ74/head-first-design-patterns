using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Observers
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;

        public ThirdPartyDisplay(ISubject weatherData)
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
