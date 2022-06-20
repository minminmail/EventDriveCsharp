using Microsoft.AspNetCore.Mvc;

namespace PolicyMicroservice.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicyController : ControllerBase
{

    private readonly ILogger<PolicyController> _logger;

    private readonly SequelClaims.EventBus.Interfaces.IRabbitMQAdapter iRabbitMQAdapter;

    private readonly SequelClaims.PolicyMicroservice.Interfaces.EventMapper _mapper;

    public PolicyController(ILogger<PolicyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPolicy")]
    public IEnumerable<Policy> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Policy
        {
            
        })
        .ToArray();
    }

    // POST api/json
    [HttpPost(Name = "CreatePolicy")]
    public async Task PostAsync([FromBody] Policy policy)
    {
        // save to DB with repository service

        // send policy event to rabbitmq
        var eventMessage = _mapper.Map<PolicyEvent>(policy);

        await iRabbitMQAdapter.Publish(eventMessage);

    }

    // PUT api/json/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Policy policy)
    {
    }

}
