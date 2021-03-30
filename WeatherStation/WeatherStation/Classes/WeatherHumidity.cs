using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Classes
{
    public class WeatherHumidity : Humidity
    {
        public WeatherHumidity(int humidity)
        {
            this.humidity = humidity;
        }

        public override int GetHumidity()
        {
            return humidity;
        }

        public override void SetHumidity(int humidity)
        {
            this.humidity = humidity;
        }
    }
}
