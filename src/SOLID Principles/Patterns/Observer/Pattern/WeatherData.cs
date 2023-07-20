namespace Observer.Pattern
{
    public class WeatherData
    {
        public WeatherData(double temperature,
            double humidity,
            double pressure)
        {
            Temperature = Math.Round(temperature, 2);
            Humadity = Math.Round(humidity, 2);
            Presurre = Math.Round(pressure, 2);
        }
        public double Temperature { get; }

        public double Humadity { get; }

        public double Presurre { get; }
    }
}
