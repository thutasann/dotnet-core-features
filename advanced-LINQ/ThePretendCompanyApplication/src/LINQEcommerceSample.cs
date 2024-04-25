namespace ThePretendCompanyApplication.src
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }

    public static class LINQEcommerceSample
    {
        public static void SampleOne()
        {
            List<Customer> customers = new()
            {
                new Customer { Id = 1, Name = "Customer 1" },
                new Customer { Id = 2, Name = "Customer 2" }
            };

            List<Order> orders = new()
            {
                new Order { Id = 1, OrderDate = DateTime.Now.AddDays(-5), CustomerId = 1 },
                new Order { Id = 2, OrderDate = DateTime.Now.AddDays(-10), CustomerId = 2 }
            };

            List<OrderItem> orderItems = new()
            {
                new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Quantity = 2 },
                new OrderItem { Id = 2, OrderId = 1, ProductId = 2, Quantity = 3 },
                new OrderItem { Id = 3, OrderId = 2, ProductId = 1, Quantity = 4 },
                new OrderItem { Id = 4, OrderId = 2, ProductId = 3, Quantity = 1 }
            };

            List<Product> products = new()
            {
                new Product { Id = 1, Name = "Product 1", Price = 10 },
                new Product { Id = 2, Name = "Product 2", Price = 20 },
                new Product { Id = 3, Name = "Product 3", Price = 30 }
            };


            var popularProducts = from product in products
                                  where product.OrderItems.Sum(oi => oi.Quantity) > 100
                                  select product;

            Console.WriteLine("Popular Products  :");
            foreach (var product in popularProducts)
            {
                Console.WriteLine($"{product.Name} - Total Orders: {product.OrderItems.Sum(oi => oi.Quantity)}");
            }

            // Joining all classes
            var query = from customer in customers
                        join order in orders on customer.Id equals order.CustomerId
                        join orderItem in orderItems on order.Id equals orderItem.OrderId
                        join product in products on orderItem.ProductId equals product.Id
                        select new
                        {
                            CustomerName = customer.Name,
                            OrderId = order.Id,
                            ProductName = product.Name,
                            Quantity = orderItem.Quantity
                        };

            Console.WriteLine("Customer\tOrder ID\tProduct\t\tQuantity");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerName}\t{item.OrderId}\t\t{item.ProductName}\t\t{item.Quantity}");
            }
        }
    }
}