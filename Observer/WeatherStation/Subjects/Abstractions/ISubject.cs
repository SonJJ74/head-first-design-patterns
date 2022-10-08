using Observer.WeatherStation.Observers.Abstractions;

namespace Observer.WeatherStation.Subjects.Abstractions
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}
