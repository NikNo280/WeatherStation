using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Interfaces
{
    public interface IReport
    {
        void GetReport(Temperature temperature, Humidity humidity, Pressure pressure);
    }
}
