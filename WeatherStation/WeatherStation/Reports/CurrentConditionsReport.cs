using System;
using System.Collections.Generic;
using System.Text;
using Weather.Interfaces;

namespace Weather.Classes
{
    public class CurrentConditionsReport : IReport
    {
        public void GetReport(Temperature temperature, Humidity humidity, Pressure pressure)
        {
            Console.WriteLine($"CurrentConditionsReport: " +
                $"\ntemperature: {temperature.GetTemperature()}" +
                $"\nhumidity: {humidity.GetHumidity()}" +
                $"\npressure: {pressure.GetPressure()}");
        }
    }
}
