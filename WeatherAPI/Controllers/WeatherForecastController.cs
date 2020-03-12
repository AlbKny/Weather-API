using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IConfiguration config;
        public WeatherForecastController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpGet("{city}")]
        public async Task<ActionResult<Weather>> Get(string city)
        {
            string apiKey = config.GetSection("ApiKey").Value;
            Weather result;
            try
            {
                OpenWeather openWeather = new OpenWeather(apiKey);
                result = await openWeather.City(city);
            }
            catch (HttpRequestException httpRequestException)
            {

                return BadRequest(httpRequestException.Message);
            }

            return result;
        }
    }
}
