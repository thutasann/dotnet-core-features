namespace pure_DSA.src.QueueSamples
{
    /// <summary>
    /// First In First Out (FIFO) <br/>
    /// Data can be added from the Back and removed from the First <br/>
    /// Can't access the elements in the middle <br/>
    /// Examples -> Operating Systems, Queueing Messages, IO requests, Mouse Movements <br/> They can be executed in the order they came in. <br/>
    /// <a href="https://tutorials.eu/queues-in-csharp/">Source</a>
    /// </summary>
    public static class QueueSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nQueueSampleOne ==>");
            Queue<int> queue = new();

            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue : " + queue.Peek());

            queue.Enqueue(2);
            Console.WriteLine("Top value in the queue is : {0} ", queue.Peek());

            queue.Enqueue(3);
            Console.WriteLine("Top value in the queue is {0} ", queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("The front value {0} was removed from the queue ", queue.Dequeue());

                Console.WriteLine("Current queue count is {0} ", queue.Count);
            }
        }

        public static void EcommerceSample()
        {
            Console.WriteLine("\nQueue Ecommerce Sample ==>");
            Queue<Order> ordersQueue = new();

            foreach (Order order1 in ReceiveOrderFromBranchOne())
            {
                ordersQueue.Enqueue(order1);
            }

            foreach (Order order2 in ReceiveOrdersFromBranchTwo())
            {
                ordersQueue.Enqueue(order2);
            }

            foreach (Order queueItem in ordersQueue.ToList())
            {
                Console.WriteLine("Initially Added Orders => " + queueItem.OrderId);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProceedOrder();
            }
        }

        public static void ContainsSample()
        {
            Console.WriteLine("\nQueue Contains Sample ==>");
            Queue<string> names = new();

            names.Enqueue("GFG");
            names.Enqueue("Geeks");
            names.Enqueue("GeeksforGeeks");
            names.Enqueue("geeks");
            names.Enqueue("Geeks123");

            if (names.Contains("GeeksforGeeks") == true)
                Console.WriteLine("Element available...!");
            else
                Console.WriteLine("Element not available...!!");
        }

        private static Order[] ReceiveOrderFromBranchOne()
        {
            Order[] orders = new Order[]
            {
                new(1,4),
                new(2,4),
                new(6,10)
            };
            return orders;
        }

        private static Order[] ReceiveOrdersFromBranchTwo()
        {
            Order[] orders = new Order[]
            {
                new(3,5),
                new(4,4),
                new(5,10),
                new(4,8)
            };
            return orders;
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int quantity)
        {
            OrderId = id;
            OrderQuantity = quantity;
        }

        public void ProceedOrder()
        {
            Console.WriteLine($"Order {OrderId} proceeded!");
        }
    }
}