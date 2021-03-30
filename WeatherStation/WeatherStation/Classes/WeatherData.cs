using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Weather.Classes
{
    public class WeatherData : INotifyPropertyChanged
    {
        private Temperature temperature;
        private Humidity humidity;
        private Pressure pressure;

        public Temperature DTemperature { get => temperature; }
        public Humidity DHumidity { get => humidity; }
        public Pressure DPressure { get => pressure; }

        public WeatherData(Temperature temperature, Humidity humidity, Pressure pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetWeatherData(Temperature temperature, Humidity humidity, Pressure pressure)
        {
            this.temperature.SetTemperature(temperature.GetTemperature());
            this.humidity.SetHumidity(humidity.GetHumidity());
            this.pressure.SetPressure(pressure.GetPressure());
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WeatherData)));
        }
    }
}
