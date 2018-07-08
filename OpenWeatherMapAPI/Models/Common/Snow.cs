using Newtonsoft.Json;

namespace OpenWeatherMapAPI.Models.Common
{
    public class Snow
    {
        /// <summary>
        /// Snow volume for last 3 hours
        /// </summary>
        [JsonProperty("3h")]
        public long VolumeLastThreeHours { get; set; }
    }
}
