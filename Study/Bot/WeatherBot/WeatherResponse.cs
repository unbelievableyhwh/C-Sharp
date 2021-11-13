using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherBot
{
    class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }
}
