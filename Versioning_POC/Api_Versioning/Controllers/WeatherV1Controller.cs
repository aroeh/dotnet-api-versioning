using Api_Versioning.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/weather")]
    public class WeatherV1Controller : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherV1Controller> _logger;

        public WeatherV1Controller(ILogger<WeatherV1Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Reached Version 1 GetWeather");

            return Enumerable.Range(1, 3).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
