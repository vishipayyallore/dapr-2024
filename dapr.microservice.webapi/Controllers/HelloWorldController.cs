using Microsoft.AspNetCore.Mvc;

namespace dapr.microservice.webapi.Controllers;

//[Route("api/[controller]")]
[ApiController]
public class HelloController(ILogger<HelloController> logger) : ControllerBase
{
    private readonly ILogger<HelloController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    [HttpGet("gethello")]
    public ActionResult<string> Get()
    {
        _logger.LogInformation("Hitting Get Hello Method.");
        Console.WriteLine("Hello, World.");

        return "Hello, World";
    }

}

