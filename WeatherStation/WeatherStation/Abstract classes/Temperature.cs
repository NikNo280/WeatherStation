using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    public abstract class Temperature
    {
        protected int degree;

        public abstract int GetTemperature();

        public abstract void SetTemperature(int degree);
    }
}
