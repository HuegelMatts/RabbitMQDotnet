using Microsoft.Practices.Unity;
using RabbitMQApp.DI;
using RabbitMQApp.RabbitMQHelper;

namespace RabbitMQApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = UnityConfig.GetMainContainer();
            var obj = container.Resolve<RabbitMqHelper>();

            var conn = obj.GetConnectionFactory();
        }
    }
}