using System;

namespace WeatherAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int FeelsLikeTemperature { get; set; }
        public int Pressure { get; set; }
        public string Description { get; set; }
        public string CityName { get; set; }
    }
}
