using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherAPI
{
    public class Weather
    {
        public Weather()
        {
        }
        public Weather(string date, int id, string temp, int pressure, string description, string cityName)
        {
            Date = date;
            Id = id;
            this.temp = temp;
            Pressure = pressure;
            Description = description;
            CityName = cityName;
        }
        public string Date { get; set; }
        public int Id { get; set; }
        public string temp { get; set; }
        public int Pressure { get; set; }
        public string Description { get; set; }
        public string CityName { get; set; }
    }
}
