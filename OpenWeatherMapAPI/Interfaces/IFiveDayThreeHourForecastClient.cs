﻿using OpenWeatherMapAPI.Models;
using OpenWeatherMapAPI.Models.Enums;
using System.Threading.Tasks;

namespace OpenWeatherMapAPI.Interfaces
{
    public interface IFiveDayThreeHourForecastClient
    {
        /// <summary>
        /// Get five day forecast weather information by city name
        /// </summary>
        /// <param name="cityName">The city name</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        Task<FiveDayThreeHourForecast> GetByName(string cityName, Units units = Units.Standard, Language language = Language.en);

        /// <summary>
        /// Get five day forecast weather information by city ID
        /// </summary>
        /// <param name="id">City ID</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        Task<FiveDayThreeHourForecast> GetById(long id, Units units = Units.Standard, Language language = Language.en);

        /// <summary>
        /// Get five day forecast information by geo coordinates
        /// </summary>
        /// <param name="latitude">The latitude</param>
        /// <param name="longitude">The longitude</param>
        /// <param name="units">The units</param>
        /// <param name="language">The languages</param>
        /// <returns>Five day forecast weather information</returns>
        Task<FiveDayThreeHourForecast> GetByCoordinates(double latitude, double longitude, Units units = Units.Standard, Language language = Language.en);

        /// <summary>
        /// Get five day forecast information by zip code
        /// </summary>
        /// <param name="zipCode">The zip code</param>
        /// <param name="countryCode">The country code</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Five day forecast weather information</returns>
        Task<FiveDayThreeHourForecast> GetByZipCode(string zipCode, string countryCode, Units units = Units.Standard, Language language = Language.en);
    }
}
