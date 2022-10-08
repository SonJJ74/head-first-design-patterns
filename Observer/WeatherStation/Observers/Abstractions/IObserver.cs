namespace Observer.WeatherStation.Observers.Abstractions
{
    public interface IObserver
    {
        void Update(double temperature, double humidty, double pressure);
    }
}
