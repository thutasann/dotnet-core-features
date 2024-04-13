namespace pure_DSA.src.HashMap
{
    public static class HashMapSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nHashMap SampleOne");
            Dictionary<string, int> ages = new()
            {
                ["Alice"] = 30,
                ["Bob"] = 0,
                ["Charlie"] = 30
            };

            Console.WriteLine($"Alice's age : {ages["Alice"]}");
            Console.WriteLine($"Bob's Aage: {ages["Bob"]}");

            if (ages.ContainsKey("Charlie"))
            {
                Console.WriteLine("Charlie's age is present in the dictionary.");
            }

            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}'age is {kvp.Value}");
            }
        }
    }
}