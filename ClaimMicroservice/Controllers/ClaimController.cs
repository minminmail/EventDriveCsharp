using Microsoft.AspNetCore.Mvc;

namespace ClaimMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class ClaimController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ClaimController> _logger;

    public ClaimController(ILogger<ClaimController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Claim> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Claim
        {

            /*
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]

            */
        })
        .ToArray();
    }
}
