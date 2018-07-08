
using Newtonsoft.Json;

namespace OpenWeatherMapAPI.Models.Common
{
    public class Main
    {
        /// <summary>
        /// Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit
        /// </summary>
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level by default, hPa
        /// </summary>
        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// Maximum temperature at the moment of calculation
        /// </summary>
        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        /// <summary>
        /// Minimum temperature at the moment of calculation
        /// </summary>
        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public int PressureSeaLevel { get; set; }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public int PressureGroundLevel { get; set; }
    }
}
