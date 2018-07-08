using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenWeatherMapAPI.Exceptions;
using OpenWeatherMapAPI.Models;
using OpenWeatherMapAPI.Models.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMapAPI.Tests
{
    [TestClass]
    public class FiveDayThreeHourForecastClientTests : OpenWeatherMapTestsBase
    {
        [TestMethod]
        public async Task GetByNameTest()
        {
            var weather = await client.FiveDayThreeHourForecast.GetByName(CityName);
            TestAllProperties(weather);
            Assert.AreEqual(CityName, weather.City.Name);
        }

        [TestMethod]
        public async Task GetByNameWithMetricSystem()
        {
            var weather = await client.FiveDayThreeHourForecast.GetByName(CityName, Units.Metric);
            TestAllProperties(weather);
            Assert.AreEqual(CityName, weather.City.Name);
        }

        [TestMethod]
        public async Task GetByNameWithMetricSystemAndLanguage()
        {
            var weatherEN = await client.FiveDayThreeHourForecast.GetByName(CityName, Units.Metric, Language.en);
            var weatherPT = await client.FiveDayThreeHourForecast.GetByName(CityName, Units.Metric, Language.pt);
            TestAllProperties(weatherEN);
            TestAllProperties(weatherPT);
            Assert.AreEqual(CityName, weatherEN.City.Name);
            Assert.AreEqual(CityName, weatherPT.City.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(OpenWeatherMapException))]
        public async Task GetByCityNameException()
        {
            var result = await client.CurrentWeather.GetByName("abcdefgh");
        }

        [TestMethod]
        public async Task GetByCoordinates()
        {
            var weather = await client.FiveDayThreeHourForecast.GetByCoordinates(Latitude, Longitude);
            TestAllProperties(weather);
            Assert.AreEqual("Chiado", weather.City.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(OpenWeatherMapException))]
        public async Task GetByCoordinatesException()
        {
            var result = await client.CurrentWeather.GetByCoordinates(-999999999999, -999999999999999);
        }

        [TestMethod]
        public async Task GetById()
        {
            var result = await client.FiveDayThreeHourForecast.GetById(CityId);
            TestAllProperties(result);
            Assert.AreEqual(CityId, result.City.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(OpenWeatherMapException))]
        public async Task GetByIdException()
        {
            var result = await client.CurrentWeather.GetById(-1);
        }

        public void TestAllProperties(FiveDayThreeHourForecast result)
        {
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.City.Name);
            Assert.IsNotNull(result.City.Coordinates);
            Assert.IsTrue(result.List.Any());
        }
    }
}
