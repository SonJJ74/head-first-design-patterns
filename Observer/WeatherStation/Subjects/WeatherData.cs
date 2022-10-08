using Observer.WeatherStation.Observers.Abstractions;
using Observer.WeatherStation.Subjects.Abstractions;

namespace Observer.WeatherStation.Subjects
{
    public class WeatherData : ISubject
    {
        public List<IObserver> Observers { get; set; } = new();

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
