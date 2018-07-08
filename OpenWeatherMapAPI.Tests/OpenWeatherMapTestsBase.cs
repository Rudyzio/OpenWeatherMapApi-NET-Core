namespace OpenWeatherMapAPI.Tests
{
    public class OpenWeatherMapTestsBase
    {
        public const string CityName = "Lisbon";
        public const string Metric = "metric";
        public const string Celsius = "celsius";
        public const double Latitude = 38.71;
        public const double Longitude = -9.14;
        public const long CityId = 2267057;
        public const string OPENWEATHERMAP_APIKEY = "APIKEY";

        public readonly OpenWeatherMapClient client = new OpenWeatherMapClient(OPENWEATHERMAP_APIKEY);
    }
}
