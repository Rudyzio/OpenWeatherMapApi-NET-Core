using Newtonsoft.Json;
using OpenWeatherMapAPI.Models.Common;
using System;
using System.Collections.Generic;

namespace OpenWeatherMapAPI.Models.Forecast
{
    public class ForecastItem
    {
        /// <summary>
        /// Time of data forecasted, unix, UTC
        /// </summary>
        [JsonProperty("dt")]
        public long UnixTimeOfData { get; set; }

        /// <summary>
        /// Information about the weather
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }

        /// <summary>
        /// More information about Weather condition codes
        /// </summary>
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        /// <summary>
        /// Clouds information
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Wind information
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

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
        /// Data/time of calculation, UTC
        /// </summary>
        [JsonProperty("dt_txt")]
        public DateTime UTCTimeOfCalculation { get; set; }

    }
}