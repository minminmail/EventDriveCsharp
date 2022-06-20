using Microsoft.AspNetCore.Mvc;

namespace PolicyMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicyController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PolicyController> _logger;

    public PolicyController(ILogger<PolicyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Policy> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Policy
        {
            /*
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]*/
        })
        .ToArray();
    }
}
