using EventBus.Messages.Interfaces;

using EventBusMessages.Interfaces;

using MassTransit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SequelClaims.EventBus.Interfaces;

public interface IRabbitMQAdapter
{ 
    void TryConnect();

    void init(string hostName,string password);
    Task Consumer(ConsumeContext<String> context);
    Task Publish(object eventMessage);
    Task Consumer(RabbitMQPolicyLineConsumer cosumer);
}
