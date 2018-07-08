using OpenWeatherMapAPI.Interfaces;
using OpenWeatherMapAPI.Models;
using OpenWeatherMapAPI.Models.Enums;
using System.Threading.Tasks;

namespace OpenWeatherMapAPI.Clients
{
    internal sealed class FiveDayThreeHourForecastClient : ClientBase, IFiveDayThreeHourForecastClient
    {
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="openWeatherMapUrl">The openweathermap URL</param>
        internal FiveDayThreeHourForecastClient(string apiKey, string openWeatherMapUrl) : base(apiKey, openWeatherMapUrl)
        {
            OpenWeatherMapUrl += "forecast";
        }

        /// <summary>
        /// Get five day forecast weather information by city name
        /// </summary>
        /// <param name="cityName">The city name</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        public async Task<FiveDayThreeHourForecast> GetByName(string cityName, Units units = Units.Standard, Language language = Language.en)
        {
            var forecastWeather = await GetByName<FiveDayThreeHourForecast>(cityName, units, language);
            return forecastWeather;
        }

        /// <summary>
        /// Get five day forecast weather information by city ID
        /// </summary>
        /// <param name="id">City ID</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        public async Task<FiveDayThreeHourForecast> GetById(long id, Units units = Units.Standard, Language language = Language.en)
        {
            var forecastWeather = await GetById<FiveDayThreeHourForecast>(id, units, language);
            return forecastWeather;
        }

        /// <summary>
        /// Get five day forecast information by geo coordinates
        /// </summary>
        /// <param name="latitude">The latitude</param>
        /// <param name="longitude">The longitude</param>
        /// <param name="units">The units</param>
        /// <param name="language">The languages</param>
        /// <returns>Five day forecast weather information</returns>
        public async Task<FiveDayThreeHourForecast> GetByCoordinates(double latitude, double longitude, Units units = Units.Standard, Language language = Language.en)
        {
            var forecastWeather = await GetByCoordinates<FiveDayThreeHourForecast>(latitude, longitude, units, language);
            return forecastWeather;
        }

        /// <summary>
        /// Get five day forecast information by zip code
        /// </summary>
        /// <param name="zipCode">The zip code</param>
        /// <param name="countryCode">The country code</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        public async Task<FiveDayThreeHourForecast> GetByZipCode(string zipCode, string countryCode, Units units = Units.Standard, Language language = Language.en)
        {
            var forecastWeather = await GetByZipCode<FiveDayThreeHourForecast>(zipCode, countryCode, units, language);
            return forecastWeather;
        }
    }
}
