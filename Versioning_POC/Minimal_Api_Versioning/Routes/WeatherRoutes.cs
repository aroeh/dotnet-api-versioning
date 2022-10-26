using Minimal_Api_Versioning.Repos;

namespace Minimal_Api_Versioning.Routes
{
    /// <summary>
    /// Versioning libraries don't seem to work here
    /// so a different strategy while not clean is to add the version to the route
    /// we'll revisit once there seems to be more progress with versioning on minimal apis
    /// </summary>
    public static class WeatherRoutes
    {
        public static void MapWeatherRoutes(this WebApplication app)
        {
            app.MapGet("/api/weather", async (IWeatherRepo repo) =>
            {
                var forecast = await repo.GetRandomWeather();
                return forecast;
            })
            .WithName("GetWeatherForecast");
        }
    }
}
