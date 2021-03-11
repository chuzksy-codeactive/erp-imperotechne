using RabbitMQ.Client;
using System;

namespace ERP.EventBus
{
    public interface IRabbitMQConnection : IDisposable
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
