using System;
using System.Collections.Generic;
using System.Text;

namespace Takerman.DesignPatterns.ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        private WeatherStation weatherStation;

        public PhoneDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        public void Update()
        {
            weatherStation.GetTemperature();
        }
    }
}
