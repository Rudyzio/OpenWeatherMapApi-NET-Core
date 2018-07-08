using Newtonsoft.Json;
using OpenWeatherMapAPI.Models.Common;
using System.Collections.Generic;

namespace OpenWeatherMapAPI.Models
{
    public class CurrentWeather
    {
        /// <summary>
        /// Geo coordinates
        /// </summary>
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Information about the weather
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        /// <summary>
        /// More information about Weather condition codes
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }

        /// <summary>
        /// Wind information
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Clouds information
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Rain information
        /// </summary>
        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// Snow information
        /// </summary>
        [JsonProperty("snow")]
        public Snow Snow { get; set; }

        /// <summary>
        /// Time of data calculation, unix, UTC
        /// </summary>
        [JsonProperty("dt")]
        public long LastUpdate { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("id")]
        public long CityId { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string CityName { get; set; }
    }
}
