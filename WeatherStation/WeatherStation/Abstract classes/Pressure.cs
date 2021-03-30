using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    public abstract class Pressure
    {
        protected int pressure;

        public abstract int GetPressure();

        public abstract void SetPressure(int pressure);
    }
}
