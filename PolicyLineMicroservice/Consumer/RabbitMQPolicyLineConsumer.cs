using MassTransit;

using SequelClaims.EventBus.Interfaces;

internal class RabbitMQPolicyLineConsumer
{
    private string queueName;

    public RabbitMQPolicyLineConsumer(string queueName)
    {
        this.queueName = queueName;

    }
}