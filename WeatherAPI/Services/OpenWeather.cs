using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAPI.Services
{
    public class OpenWeather
    {
        private string ApiKey { get; set; }
        public OpenWeather()
        {

        }
        public OpenWeather(string apiKay)
        {
            this.ApiKey = apiKay;
        }
        public async Task<Weather> City(string city)
        {

            if (ApiKey == null || ApiKey == "")
            {
                throw new WrongApiKeyException("You are missing Api Key");
            }
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org");
            var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid={ApiKey}&units=metric");
            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();
            OpenWeatherResponse rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
            Weather openWeather = new Weather(DateTime.Now.ToString(), rawWeather.id, rawWeather.Main.Temp, rawWeather.Main.Pressure, string.Join(",", rawWeather.Weather.Select(x => x.Main)), rawWeather.Name);
            client.Dispose();
            return openWeather;
        }
    }
}
