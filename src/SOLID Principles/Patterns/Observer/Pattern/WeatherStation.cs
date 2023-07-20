using Observer.Extensions;

namespace Observer.Pattern
{
    public class WeatherStation : IObservable<WeatherData>
    {
        private System.Timers.Timer timer;
        private WeatherData _weather;
        private List<IObserver<WeatherData>> observers = new List<IObserver<WeatherData>>();

        public WeatherStation()
        {
            var random = new Random();
            _weather = new WeatherData(random.Next(20, 40),
                random.Next(40, 60),
                random.Next(100, 200));
            timer = new System.Timers.Timer(2000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            var random = new Random();
            var weather = new WeatherData(
                _weather.Temperature + random.NextDouble(-2, 2),
                _weather.Humadity + random.NextDouble(-2, 2),
                _weather.Presurre + random.NextDouble(-2, 2)
                );

            observers.ForEach(o => o.OnNext(weather));
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            observers.Add(observer);
            return new Unsubscriber<WeatherData>(observers, observer);
        }
    }
}
