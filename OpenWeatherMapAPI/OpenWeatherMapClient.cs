using OpenWeatherMapAPI.Clients;
using OpenWeatherMapAPI.Interfaces;

namespace OpenWeatherMapAPI
{
    /// <summary>
    /// Main class that can be called to interact with the Openweathermap API
    /// </summary>
    public class OpenWeatherMapClient
    {
        /// <summary>
        /// Openweathermap URL
        /// </summary>
        private static readonly string OpenWeatherMapUrl = "http://api.openweathermap.org/data/2.5/";

        /// <summary>
        /// The Current Weather client
        /// </summary>
        public ICurrentWeatherClient CurrentWeather { get; set; }

        /// <summary>
        /// The 5 day/3 hours forecast client
        /// </summary>
        public IFiveDayThreeHourForecastClient FiveDayThreeHourForecast { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="apiKey">The Openweathermap api key</param>
        public OpenWeatherMapClient(string apiKey)
        {
            CurrentWeather = new CurrentWeatherClient(apiKey, OpenWeatherMapUrl);
            FiveDayThreeHourForecast = new FiveDayThreeHourForecastClient(apiKey, OpenWeatherMapUrl);
        }
    }
}
