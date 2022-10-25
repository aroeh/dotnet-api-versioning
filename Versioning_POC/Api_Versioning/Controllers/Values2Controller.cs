using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/values")]
    public class Values2Controller : ControllerBase
    {
        private readonly ILogger<Values2Controller> _logger;

        public Values2Controller(ILogger<Values2Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Reached Values Version 2.0");

            return "Reached Values Version 2.0.  Now serving Cake!";
        }
    }
}
