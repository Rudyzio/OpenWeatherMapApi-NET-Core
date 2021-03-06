﻿using System.Threading.Tasks;
using OpenWeatherMapAPI.Interfaces;
using OpenWeatherMapAPI.Models;
using OpenWeatherMapAPI.Models.Enums;

namespace OpenWeatherMapAPI.Clients
{
    internal sealed class CurrentWeatherClient : ClientBase, ICurrentWeatherClient
    {
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="openWeatherMapUrl">The openweathermap URL</param>
        internal CurrentWeatherClient(string apiKey, string openWeatherMapUrl) : base(apiKey, openWeatherMapUrl)
        {
            OpenWeatherMapUrl += "weather";
        }

        /// <summary>
        /// Get current weather information by city name
        /// </summary>
        /// <param name="cityName">The city name</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Current weather information</returns>
        public async Task<CurrentWeather> GetByName(string cityName, Units units = Units.Standard, Language language = Language.en)
        {
            var currentWeather = await GetByName<CurrentWeather>(cityName, units, language);
            return currentWeather;
        }

        /// <summary>
        /// Get current weather information by city ID
        /// </summary>
        /// <param name="id">City ID</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Current weather information</returns>
        public async Task<CurrentWeather> GetById(long id, Units units = Units.Standard, Language language = Language.en)
        {
            var currentWeather = await GetById<CurrentWeather>(id, units, language);
            return currentWeather;
        }

        /// <summary>
        /// Get current information by geo coordinates
        /// </summary>
        /// <param name="latitude">The latitude</param>
        /// <param name="longitude">The longitude</param>
        /// <param name="units">The units</param>
        /// <param name="language">The languages</param>
        /// <returns>Current weather information</returns>
        public async Task<CurrentWeather> GetByCoordinates(double latitude, double longitude, Units units = Units.Standard, Language language = Language.en)
        {
            var currentWeather = await GetByCoordinates<CurrentWeather>(latitude, longitude, units, language);
            return currentWeather;
        }

        /// <summary>
        /// Get current information by zip code
        /// </summary>
        /// <param name="zipCode">The zip code</param>
        /// <param name="countryCode">The country code</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Current weather information</returns>
        public async Task<CurrentWeather> GetByZipCode(string zipCode, string countryCode, Units units = Units.Standard, Language language = Language.en)
        {
            var currentWeather = await GetByZipCode<CurrentWeather>(zipCode, countryCode, units, language);
            return currentWeather;
        }
    }
}
