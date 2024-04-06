namespace pure_DSA.src.QueueSamples
{
    /// <summary>
    /// - allows you to process items based on their priority rather than the order of insertion <br/> 
    /// - This can be useful when certain tasks need to be processed before others based on their importance or urgency
    /// </summary>
    public class PriorityQueue<TPriority, TValue> where TPriority : notnull
    {
        private readonly SortedDictionary<TPriority, Queue<TValue>> _queues = new();
        public int Count { get; private set; }

        public void Enqueue(TPriority priority, TValue value)
        {
            if (!_queues.TryGetValue(priority, out var queue))
            {
                queue = new Queue<TValue>();
                _queues[priority] = queue;
            }
            queue.Enqueue(value);
            Count++;
        }

        public KeyValuePair<TPriority, TValue> Dequeue()
        {
            var firstQueue = _queues.First();
            var value = firstQueue.Value.Dequeue();
            if (firstQueue.Value.Count == 0)
            {
                _queues.Remove(firstQueue.Key);
            }
            Count--;

            return new(firstQueue.Key, value);
        }

    }

    public class KeyValuePair<TKey, TValue>
    {
        public TKey Priority { get; set; }
        public TValue Value { get; set; }

        public KeyValuePair(TKey key, TValue value)
        {
            Priority = key;
            Value = value;
        }
    }

    /// <summary>
    /// Priority Queue Usage
    /// </summary>
    public static class ProprityQueueUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nProprity Queue Sample Usage ==>");
            PriorityQueue<int, string> priorityQueue = new();

            priorityQueue.Enqueue(3, "Task C");
            priorityQueue.Enqueue(1, "Task A");
            priorityQueue.Enqueue(2, "Task B");

            while (priorityQueue.Count > 0)
            {
                var item = priorityQueue.Dequeue();
                Console.WriteLine($"Priority : {item.Priority}, Value: {item.Value}");
            }
        }
    }
}