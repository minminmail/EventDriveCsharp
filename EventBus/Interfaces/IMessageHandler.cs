using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequelClaims.EventBus.Interfaces;
internal interface IMessageHandler<T> where T : EventBusMessages.Interfaces.IMessage
{
    Task Handle(T message);
}
