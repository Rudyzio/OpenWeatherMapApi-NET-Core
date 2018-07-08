using Newtonsoft.Json;

namespace OpenWeatherMapAPI.Models.Common
{
    public class Clouds
    {
        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonProperty("all")]
        public int CloudinessPercentage { get; set; }
    }
}
