using System.Collections.Generic;

namespace WeatherAPI.Services
{
    public class OpenWeatherResponse
    {
        public int id { get; set; }
        public string Name { get; set; }

        public IEnumerable<WeatherDescription> Weather { get; set; }

        public Main Main { get; set; }
        public Sys Sys { get; set; }
    }
}
