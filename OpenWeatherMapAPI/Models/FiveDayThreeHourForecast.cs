using Newtonsoft.Json;
using OpenWeatherMapAPI.Models.Forecast;
using System.Collections.Generic;

namespace OpenWeatherMapAPI.Models
{
    public class FiveDayThreeHourForecast
    {
        /// <summary>
        /// The city
        /// </summary>
        [JsonProperty("city")]
        public City City { get; set; }

        /// <summary>
        /// The list of Forecast Items
        /// </summary>
        [JsonProperty("list")]
        public List<ForecastItem> List { get; set; }
    }
}
