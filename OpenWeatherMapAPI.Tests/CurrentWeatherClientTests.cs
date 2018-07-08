using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenWeatherMapAPI.Exceptions;
using OpenWeatherMapAPI.Models;
using OpenWeatherMapAPI.Models.Enums;
using System.Threading.Tasks;

namespace OpenWeatherMapAPI.Tests
{
    [TestClass]
    public class CurrentWeatherClientTests : OpenWeatherMapTestsBase
    {
        [TestMethod]
        public async Task GetByNameTest()
        {
            var weather = await client.CurrentWeather.GetByName(CityName);
            TestAllProperties(weather);
            Assert.AreEqual(CityName, weather.CityName);
        }

        [TestMethod]
        public async Task GetByNameWithMetricSystem()
        {
            var weather = await client.CurrentWeather.GetByName(CityName, Units.Metric);
            TestAllProperties(weather);
            Assert.AreEqual(CityName, weather.CityName);
        }

        [TestMethod]
        public async Task GetByNameWithMetricSystemAndLanguage()
        {
            var weatherEN = await client.CurrentWeather.GetByName(CityName, Units.Metric, Language.en);
            var weatherPT = await client.CurrentWeather.GetByName(CityName, Units.Metric, Language.pt);
            TestAllProperties(weatherEN);
            TestAllProperties(weatherPT);
            Assert.AreEqual(CityName, weatherEN.CityName);
            Assert.AreEqual(CityName, weatherPT.CityName);
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
            var weather = await client.CurrentWeather.GetByCoordinates(Latitude, Longitude);
            TestAllProperties(weather);
            Assert.AreEqual(Latitude, weather.Coordinates.Latitude);
            Assert.AreEqual(Longitude, weather.Coordinates.Longitude);
            Assert.AreEqual("Chiado", weather.CityName);
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
            var result = await client.CurrentWeather.GetById(CityId);
            TestAllProperties(result);
            Assert.AreEqual(CityId, result.CityId);
        }

        [TestMethod]
        [ExpectedException(typeof(OpenWeatherMapException))]
        public async Task GetByIdException()
        {
            var result = await client.CurrentWeather.GetById(-1);
        }

        private void TestAllProperties(CurrentWeather currentWeather)
        {
            Assert.IsNotNull(currentWeather);
            Assert.IsNotNull(currentWeather.CityId);
            Assert.IsNotNull(currentWeather.CityName);
            Assert.IsNotNull(currentWeather.Clouds);
            Assert.IsNotNull(currentWeather.Coordinates);
            Assert.IsNotNull(currentWeather.Main);
            Assert.IsNotNull(currentWeather.LastUpdate);
            Assert.IsNotNull(currentWeather.Weather);
            Assert.IsNotNull(currentWeather.Wind);
        }
    }
}
