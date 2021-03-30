using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Classes
{
    public class WeatherPressure : Pressure
    {
        public WeatherPressure(int pressure)
        {
            this.pressure = pressure;
        }

        public override int GetPressure()
        {
            return pressure;
        }

        public override void SetPressure(int pressure)
        {
            this.pressure = pressure;
        }
    }
}
