
# .NET Core OpenWeatherMap API

Class library built in .NET Core in order to interact with the [OpenWeatherMap API](http://openweathermap.org/API).  

Currently it only provides interaction with the free tier of OpenWeatherMap:
*  [Current weather data](https://openweathermap.org/current)
*  [5 day / 3 hour forecast](https://openweathermap.org/forecast5)

Regardless, it is planned to be extended to also handle the paid tiers from OpenWeatherMap.
## Examples
```c#
var client = new  OpenWeatherMapClient(OPENWEATHERMAP_APIKEY);
var currentWeather = await  client.CurrentWeather.GetByName("Lisbon");
var foreacastWeather = await  client.FiveDayThreeHourForecast.GetByName("Lisbon");
```
## Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owner of this repository before making a change.

## License
This project is licensed under the MIT License