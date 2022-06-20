using EventBus.Messages.Interfaces;

using EventBusMessages.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequelClaims.EventBus.Interfaces;

public delegate void MessageReceived(MessageReceivedEventArgs args);
public interface IRabbitMQAdapter
{
    event MessageReceived MessageReceived;
    void TryConnect();
    void BasicPublish(ICommand command, string destination);
    void BasicPublish(IEvent @event);
    void StartConsuming();
}
