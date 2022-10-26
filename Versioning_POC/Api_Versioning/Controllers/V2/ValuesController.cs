using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
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
