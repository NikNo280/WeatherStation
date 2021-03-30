using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Classes
{
    public class WeatherTemperature : Temperature
    {
        public WeatherTemperature(int degree)
        {
            this.degree = degree;
        }

        public override int GetTemperature()
        {
            return degree;
        }

        public override void SetTemperature(int degree)
        {
            this.degree = degree;
        }
    }
}
