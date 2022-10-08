using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private double _temperature;
        private double _humidity;
        public double _pressure;

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(
                _temperature,
                _humidity,
                _pressure));
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(
            double temperature,
            double humidity,
            double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }
}
