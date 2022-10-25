using Api_Versioning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/weather")]
    public class WeatherV2Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherV2Controller> _logger;

        public WeatherV2Controller(ILogger<WeatherV2Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Reached Version 2 GetWeather");

            return Enumerable.Range(1, 6).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
