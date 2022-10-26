using Minimal_Api_Versioning.Models;

namespace Minimal_Api_Versioning.Repos
{
    public class WeatherRepo : IWeatherRepo
    {
        private readonly string[] summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Moved from the default template.
        /// Returns a collection of randomly generated weather forecasts
        /// </summary>
        /// <returns>IEnumerable<WeatherForecast></returns>
        public async Task<IEnumerable<WeatherForecast>> GetRandomWeather()
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();

            return await Task.FromResult(forecast);
        }
    }
}
