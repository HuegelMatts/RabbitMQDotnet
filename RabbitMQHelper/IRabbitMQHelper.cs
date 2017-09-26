using RabbitMQ.Client;

namespace RabbitMQApp.RabbitMQHelper
{
    public interface IRabbitMQHelper
    {
        string QueueName { get; set; }

        ConnectionFactory GetConnectionFactory();
    }
}