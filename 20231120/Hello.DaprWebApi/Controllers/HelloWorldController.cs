using Microsoft.AspNetCore.Mvc;

namespace Hello.DaprWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloWorldController(ILogger<HelloWorldController> logger) : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    // GET http://localhost:5000/api/HelloWorld/Hello
    [HttpGet("Hello")]
    public ActionResult<string> Get()
    {
        _logger.LogInformation("Hitting Get Hello Method.");

        return "Hello -> DAPR, .NET 8 World !!";
    }

    // GET http://localhost:5000/api/HelloWorld/Greetings?userName=Sri%20Varu
    [HttpGet("Greetings")]
    public ActionResult<string> Greet([FromQuery] string userName)
    {
        _logger.LogInformation("Hitting Get Hello Method.");

        return $"Hello -> {userName} !!";
    }

}

