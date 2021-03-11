using ERP.EventBus.Events;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace ERP.EventBus.Producer
{
    public class MTOEventProducer
    {
        private readonly IRabbitMQConnection _connection;

        public MTOEventProducer(IRabbitMQConnection connection)
        {
            _connection = connection;
        }

        public void PublishMTOEvent(string queueName, MaterialTakeOffEvent mtoPublishModel)
        {
            using var channel = _connection.CreateModel();
            channel.QueueDeclare(queue: queueName, false, exclusive: false, autoDelete: false, arguments: null);
            var message = JsonConvert.SerializeObject(mtoPublishModel);
            var body = Encoding.UTF8.GetBytes(message);

            IBasicProperties properties = channel.CreateBasicProperties();
            properties.Persistent = true;
            properties.DeliveryMode = 2;

            channel.ConfirmSelect();
            channel.BasicPublish(exchange: "", routingKey: queueName, mandatory: true, basicProperties: properties, body: body);
            channel.WaitForConfirmsOrDie();

            channel.BasicAcks += (sender, eventArgs) =>
            {
                Console.WriteLine("Sent RabbitMQ");
            };

            channel.ConfirmSelect();
        }
    }
}
