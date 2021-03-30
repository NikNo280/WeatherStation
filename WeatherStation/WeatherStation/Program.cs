using System;
using Weather.Classes;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherTemperature = new WeatherTemperature(20);
            var weatherHumidity = new WeatherHumidity(10);
            var weatherPressure = new WeatherPressure(15);
            var weatherData = new WeatherData(weatherTemperature, weatherHumidity, weatherPressure);
            var currentConditionsReport  = new CurrentConditionsReport();
            var statisticReport = new StatisticReport();
            var weatherStation = new WeatherStation(weatherData, currentConditionsReport, statisticReport);
            weatherData.SetWeatherData(weatherTemperature, weatherHumidity, weatherPressure);
            weatherTemperature.SetTemperature(35);
            weatherData.SetWeatherData(weatherTemperature, weatherHumidity, weatherPressure);
            weatherHumidity.SetHumidity(25);
            weatherData.SetWeatherData(weatherTemperature, weatherHumidity, weatherPressure);
            weatherPressure.SetPressure(100);
            weatherData.SetWeatherData(weatherTemperature, weatherHumidity, weatherPressure);
        }
    }
}
