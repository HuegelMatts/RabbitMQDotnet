namespace RabbitMQApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private Customer CreateCustomerObj()
        {
            var obj = new Customer
            {
                Id = 1,
                Email = "john@nike.com",
                Name = "John Nike"
            };
            return obj;
        }
    }
}