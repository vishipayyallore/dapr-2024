using Microsoft.AspNetCore.Mvc;

namespace dapr.microservice.webapi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController(ILogger<HelloWorldController> logger) : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    [HttpGet("gethello")]
    public ActionResult<string> Get()
    {
        _logger.LogInformation("Hitting Get Hello Method.");
        Console.WriteLine("Hello, World.");

        return "Hello, World";
    }

}

