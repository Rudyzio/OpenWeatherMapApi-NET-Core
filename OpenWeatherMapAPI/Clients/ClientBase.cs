using Newtonsoft.Json.Linq;
using OpenWeatherMapAPI.Exceptions;
using OpenWeatherMapAPI.Models.Enums;
using Reveal.EmailTemplateHandler.Helpers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapAPI.Clients
{
    internal abstract class ClientBase
    {
        /// <summary>
        /// The Http Client to send requests to Openweathermap
        /// </summary>
        private HttpClient HttpClient { get; set; }

        /// <summary>
        /// The api key
        /// </summary>
        private string ApiKey { get; set; }

        /// <summary>
        /// The Openweathermap URL
        /// </summary>
        protected string OpenWeatherMapUrl { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="openWeatherMapUrl">The Openweathermap URL</param>
        protected ClientBase(string apiKey, string openWeatherMapUrl)
        {
            ApiKey = apiKey;
            OpenWeatherMapUrl = openWeatherMapUrl;
            CreateHttpClient();
        }

        /// <summary>
        /// Get weather information by name
        /// </summary>
        /// <typeparam name="T">Generic parameter</typeparam>
        /// <param name="cityName">The city name</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Information about weather</returns>
        internal async Task<T> GetByName<T>(string cityName, Units units = Units.Standard, Language language = Language.en)
        {
            ArgumentValidator.ArgumentStringNotEmpty(cityName, "cityName");

            var requestUrl = OpenWeatherMapUrl + "?q=" + cityName + "&appid=" + ApiKey + AddMetricSystem(units) + AddLanguage(language);

            var response = GetRequest(requestUrl);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var weather = JObject.Parse(stringResponse).ToObject<T>();

            return weather;
        }

        /// <summary>
        /// Get weather information by City ID
        /// </summary>
        /// <typeparam name="T">Generic parameter</typeparam>
        /// <param name="id">The city ID</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Information about weather</returns>
        internal async Task<T> GetById<T>(long id, Units units = Units.Standard, Language language = Language.en)
        {
            ArgumentValidator.ArgumentNotNull(id, "id");

            var requestUrl = OpenWeatherMapUrl + "?id=" + id + "&appid=" + ApiKey + AddMetricSystem(units) + AddLanguage(language);

            var response = GetRequest(requestUrl);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var weather = JObject.Parse(stringResponse).ToObject<T>();

            return weather;
        }

        /// <summary>
        /// Gets weather information by geo coordinates
        /// </summary>
        /// <typeparam name="T">Generic parameter</typeparam>
        /// <param name="latitude">The latitude</param>
        /// <param name="longitude">The longitude</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Information about weather</returns>
        internal async Task<T> GetByCoordinates<T>(double latitude, double longitude, Units units = Units.Standard, Language language = Language.en)
        {
            ArgumentValidator.ArgumentNotNull(latitude, "latitude");
            ArgumentValidator.ArgumentNotNull(longitude, "longitude");
            var requestUrl = OpenWeatherMapUrl + "?lat=" + latitude + "&lon=" + longitude + "&appid=" + ApiKey + AddMetricSystem(units) + AddLanguage(language);

            var response = GetRequest(requestUrl);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var weather = JObject.Parse(stringResponse).ToObject<T>();

            return weather;
        }

        /// <summary>
        /// Gets weather information by zip code
        /// </summary>
        /// <typeparam name="T">Generic parameter</typeparam>
        /// <param name="zipCode">The zip code</param>
        /// <param name="countryCode">The country code</param>
        /// <param name="units">The units</param>
        /// <param name="language">The language</param>
        /// <returns>Information about weather</returns>
        internal async Task<T> GetByZipCode<T>(string zipCode, string countryCode, Units units = Units.Standard, Language language = Language.en)
        {
            ArgumentValidator.ArgumentStringNotEmpty(zipCode, "zipCode");
            ArgumentValidator.ArgumentStringNotEmpty(countryCode, "countryCode");

            var requestUrl = OpenWeatherMapUrl + "?zip=" + zipCode + "," + countryCode + "&appid=" + ApiKey + AddMetricSystem(units) + AddLanguage(language);

            var response = GetRequest(requestUrl);

            var stringResponse = await response.Content.ReadAsStringAsync();
            var weather = JObject.Parse(stringResponse).ToObject<T>();

            return weather;
        }

        /// <summary>
        /// Makes a GET request to the provided URL
        /// </summary>
        /// <param name="url">The URL</param>
        /// <returns>A HTTP response message object</returns>
        /// <exception cref="OpenWeatherMapException">
        ///     Thrown when something got wrong making the GET request
        /// </exception>
        private HttpResponseMessage GetRequest(string url) 
        {
            HttpResponseMessage response = HttpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                throw new OpenWeatherMapException(response);
            }
        }

        /// <summary>
        /// Creates the HTTP Client
        /// </summary>
        private void CreateHttpClient()
        {
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri(OpenWeatherMapUrl)
            };
        }

        /// <summary>
        /// Returns a string to be inserted in a request regarding units
        /// </summary>
        /// <param name="units"></param>
        /// <returns>A string to be inserted in a request regarding units</returns>
        private string AddMetricSystem(Units units)
        {
            switch (units)
            {
                case Units.Metric:
                    return "&units=metric";
                case Units.Imperial:
                    return "&units=imperial";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Returns a string to be inserted in a request regarding language
        /// </summary>
        /// <param name="language"></param>
        /// <returns>A string to be inserted in a request regarding language</returns>
        private string AddLanguage(Language language)
        {
            var toReturn = string.Empty;

            if (language != Language.en)
            {
                toReturn = "&lang" + language.ToString().ToLower();
            }

            return toReturn;
        }
    }
}
