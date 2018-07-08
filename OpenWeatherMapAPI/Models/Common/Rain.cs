using Newtonsoft.Json;

namespace OpenWeatherMapAPI.Models
{
    public class Rain
    {
        /// <summary>
        /// Rain volume for last 3 hours, mm
        /// </summary>
        [JsonProperty("3h")]
        public int VolumeLastThreeHours { get; set; }
    }
}
