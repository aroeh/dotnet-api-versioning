using Minimal_Api_Versioning.Models;

namespace Minimal_Api_Versioning.Repos
{
    public interface IWeatherRepo
    {
        /// <summary>
        /// Moved from the default template.
        /// Returns a collection of randomly generated weather forecasts
        /// </summary>
        /// <returns>IEnumerable<WeatherForecast></returns>
        Task<IEnumerable<WeatherForecast>> GetRandomWeather();
    }
}
