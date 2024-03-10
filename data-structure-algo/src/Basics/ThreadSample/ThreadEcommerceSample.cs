namespace data_structure_algo.src.Basics.ThreadSample
{

    /// <summary>
    /// Customer Class
    /// </summary>
    public class Customer
    {
        public string Name { get; }

        public Customer(string Name)
        {
            this.Name = Name;
        }

        public void PlaceOrder()
        {
            Random random = new();
            int numItems = random.Next(1, 5);

            Console.WriteLine($"Customer : {Name} is browsing the online store");

            for (int i = 0; i <= numItems; i++)
            {
                Console.WriteLine($"Customer : {Name} added {i} to the cart. ");
                Thread.Sleep(random.Next(500, 1000));
            }

            Console.WriteLine($"Customer: {Name} is checking and placing an order...");

            Thread.Sleep(random.Next(2000, 4000));

            Console.WriteLine($"Customer : {Name}'s order has been placed successfully.");

        }
    }

    /// <summary>
    /// Thread Ecommerce Sample
    /// - Simulate an e-commerce system with multiple customers and orders
    /// </summary>
    public class ThreadEcommerceSample
    {
        public void SampleOne()
        {
            List<Thread> customerThreads = new();

            for (int i = 1; i <= 5; i++)
            {
                Thread customerThread = new(() =>
                {
                    Customer customer = new($"Customer-{i}");
                    customer.PlaceOrder();
                });

                customerThreads.Add(customerThread);
                customerThread.Start();
            }

            // wait for all customer threads to finish
            foreach (Thread thread in customerThreads)
            {
                thread.Join();
            }

            Console.WriteLine($"All orders {customerThreads.Count} have been placed. Thank you for shopping with us");
        }
    }
}