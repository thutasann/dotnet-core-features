namespace data_structure_algo.src.Fundamentals
{
    /// <summary>
    /// First In First Out (FIFO) <br/>
    /// Data can be added from the Back and removed from the First <br/>
    /// Can't access the elements in the middle <br/>
    /// Examples -> Operating Systems, Queueing Messages, IO requests, Mouse Movements <br/> They can be executed in the order they came in. <br/>
    /// <a href="https://tutorials.eu/queues-in-csharp/">Source</a>
    /// </summary>
    public class QueueFundamental
    {
        public void SampleOne()
        {
            Console.WriteLine("------->> Queue Fundamental");
            Queue<int> queue = new();

            queue.Enqueue(1);
            Console.WriteLine("The value at the front of the queue is {0} ", queue.Peek());

            queue.Enqueue(2);
            Console.WriteLine("Top value in the queue is : {0} ", queue.Peek());

            queue.Enqueue(3);
            Console.WriteLine("Top value in the queue is {0} ", queue.Peek());

            while (queue.Count > 0)
            {
                // Deque() will return the element that was removed from the queue
                Console.WriteLine("The Front value {0} was removed from the queue ", queue.Dequeue());

                // Print the Queue count
                Console.WriteLine("Current queue count is {0} ", queue.Count);
            }
        }

        // -------------------------------

        /// <summary>
        /// Ecommerce Order Sample 🚀
        /// </summary>
        public void EcommerceOrderSample()
        {
            Console.WriteLine("------->> Queue Ecommerce Order Sample 🛍️");
            Queue<Order> ordersQueue = new();

            foreach (Order order1 in ReceiveOrdersFromBranch1())
            {
                // add each order to the queue
                ordersQueue.Enqueue(order1);
            }

            foreach (Order order2 in ReceiveOrdersFromBranch2())
            {
                // add each order to the queue
                ordersQueue.Enqueue(order2);
            }

            foreach (var queueItem in ordersQueue.ToList())
            {
                Console.WriteLine("added Initial queueItem " + queueItem.OrderId);
            }

            // as long as queue is not empty
            while (ordersQueue.Count > 0)
            {
                // remove the order At the Front of the queue
                // and store it in a variable called `currentOrder`
                Order currentOrder = ordersQueue.Dequeue();
                // proceed the order
                currentOrder.ProceedOrder();
            }
        }

        private static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new(1,5),
                new(2,4),
                new(6,10)
            };
            return orders;
        }

        private static Order[] ReceiveOrdersFromBranch2()
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

    /// <summary>
    /// Real World Ecommerce Order Class
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            OrderId = id;
            OrderQuantity = orderQuantity;
        }

        public void ProceedOrder()
        {
            Console.WriteLine($"Order {OrderId} proceeded!");
        }

    }
}