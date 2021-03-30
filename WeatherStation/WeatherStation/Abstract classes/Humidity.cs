using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    public abstract class Humidity
    {
        protected int humidity;

        public abstract int GetHumidity();

        public abstract void SetHumidity(int humidity);
    }
}
