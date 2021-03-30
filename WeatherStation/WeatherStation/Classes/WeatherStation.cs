using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Weather.Interfaces;

namespace Weather.Classes
{
    public class WeatherStation
    {
        private WeatherData weatherData;
        private IReport[] reports;
        public WeatherStation(WeatherData weatherData, params IReport[] reports)
        {
            this.weatherData = weatherData;
            this.reports = reports;
            weatherData.PropertyChanged += GetReport;
        }

        public void GetReport(object sendet, PropertyChangedEventArgs e)
        {
            foreach (var report in reports)
            {
                report.GetReport(this.weatherData.DTemperature, this.weatherData.DHumidity, this.weatherData.DPressure);
            }
        }
    }
}
