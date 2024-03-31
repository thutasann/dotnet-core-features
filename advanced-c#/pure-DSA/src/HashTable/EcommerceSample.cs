namespace pure_DSA.src.HashTable
{
    public class EcommerceHashTableSample<Tkey, Tvalue>
    {
        private const int DefaultCapacity = 16;
        private const float DefaultLoadFactor = 0.75f;

        private LinkedList<KeyValuePair<Tkey, Tvalue>>[]? buckets;
        private int size;
        private int capacity;
        private float loadFactor;

        public EcommerceHashTableSample()
        {
            Initialize(DefaultCapacity, DefaultLoadFactor);
        }

        public EcommerceHashTableSample(int capacity, float loadFactor)
        {
            this.capacity = capacity;
            this.loadFactor = loadFactor;
        }

        public void Add(Tkey key, Tvalue value)
        {
            if (size >= capacity * loadFactor)
            {
                Resize();
            }

            var bucketIndex = GetBucketIndex(key);
            if (buckets![bucketIndex] == null)
            {
                buckets[bucketIndex] = new LinkedList<KeyValuePair<Tkey, Tvalue>>();
            }

            buckets[bucketIndex].AddLast(new KeyValuePair<Tkey, Tvalue>(key, value));
            size++;
        }

        public bool TryGetValue(Tkey key, out Tvalue value)
        {
            int bucketIndex = GetBucketIndex(key);
            if (buckets![bucketIndex] != null)
            {
                foreach (var pair in buckets[bucketIndex])
                {
                    if (pair.Key!.Equals(key))
                    {
                        value = pair.Value;
                        return true;
                    }
                }
            }
            value = default!;
            return false;
        }

        private int GetBucketIndex(Tkey key)
        {
            return Math.Abs(key!.GetHashCode()) % capacity;
        }

        private void Initialize(int capacity, float loadFactor)
        {
            this.capacity = capacity;
            this.loadFactor = loadFactor;
            this.buckets = new LinkedList<KeyValuePair<Tkey, Tvalue>>[capacity];
        }

        private void Resize()
        {
            capacity *= 2;
            var newBuckets = new LinkedList<KeyValuePair<Tkey, Tvalue>>[capacity];
            foreach (var bucket in buckets!)
            {
                if (bucket != null)
                {
                    foreach (var pair in bucket)
                    {
                        int newIndex = Math.Abs(pair.Key!.GetHashCode()) % capacity;
                        if (newBuckets[newIndex] == null)
                        {
                            newBuckets[newIndex] = new LinkedList<KeyValuePair<Tkey, Tvalue>>();
                        }
                        newBuckets[newIndex].AddLast(pair);
                    }
                }
            }
            buckets = newBuckets;
        }
    }

    // ---------------------- Usage ----------------------
    public static class EcommerceHashTableUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nEcommerceHashTableUsage ====> ");
            EcommerceHashTableSample<string, int> ecommerceHashTableSample = new();
            ecommerceHashTableSample.Add("Alice", 30);
            ecommerceHashTableSample.Add("Bob", 40);
            ecommerceHashTableSample.Add("Charlie", 25);
            ecommerceHashTableSample.Add("David", 35);
            int age;

            if (ecommerceHashTableSample.TryGetValue("Alice", out age))
            {
                Console.WriteLine($"Alice age is {age}");
            }
            if (ecommerceHashTableSample.TryGetValue("Eve", out age))
            {
                Console.WriteLine($"Eve's age is {age}");
            }
            else
            {
                Console.WriteLine("Eve's age is not found");
            }
        }
    }
}