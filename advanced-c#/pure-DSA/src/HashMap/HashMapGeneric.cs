namespace pure_DSA.src.HashMap
{
    public class HashMapGeneric<TKey, TValue> where TKey : notnull
    {
        private Dictionary<TKey, TValue> dictionary = new();

        public void Put(TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        public TValue Get(TKey key)
        {
            if (dictionary.ContainsKey(key))
            {
                return dictionary[key];
            }
            throw new KeyNotFoundException($"Key {key} is not found");
        }

        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }

        public void Remove(TKey key)
        {
            dictionary.Remove(key);
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public int Count
        {
            get { return dictionary.Count; }
        }
    }

    public static class HashMapGenericUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nHashMap Generic Usage SampleOne");
            HashMapGeneric<string, int> ages = new();
            ages.Put("Alice", 30);
            ages.Put("Bob", 25);
            ages.Put("Charlie", 35);

            Console.WriteLine($"Alice's age: {ages.Get("Alice")}");
            Console.WriteLine($"Bob's age: {ages.Get("Bob")}");

            if (ages.ContainsKey("Charlie"))
            {
                Console.WriteLine("Charlie's age is present in the HashMap.");
            }
        }
    }
}