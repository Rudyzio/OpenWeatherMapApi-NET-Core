using Newtonsoft.Json;

namespace OpenWeatherMapAPI.Models.Common
{
    public class Coordinates
    {
        /// <summary>
        /// City geo location, longitude
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// City geo location, latitude
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
