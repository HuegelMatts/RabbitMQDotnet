using RabbitMQ.Client;

namespace RabbitMQApp.RabbitMQHelper
{
    public class RabbitMqHelper : IRabbitMQHelper
    {
        public string QueueName { get; set; }

        public ConnectionFactory GetConnectionFactory()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            return connectionFactory;
        }
    }
}