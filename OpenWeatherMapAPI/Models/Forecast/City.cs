using Newtonsoft.Json;
using OpenWeatherMapAPI.Models.Common;

namespace OpenWeatherMapAPI.Models.Forecast
{
    public class City
    {
        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The city geo coordinates
        /// </summary>
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Country Code
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
