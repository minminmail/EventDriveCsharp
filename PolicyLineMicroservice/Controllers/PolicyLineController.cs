using Microsoft.AspNetCore.Mvc;

namespace PolicyLineMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicyLineController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PolicyLineController> _logger;

    public PolicyLineController(ILogger<PolicyLineController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<PolicyLine> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new PolicyLine
        {/*
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            */
        })
        .ToArray();
    }
}
