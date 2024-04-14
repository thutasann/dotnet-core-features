namespace pure_DSA.src.HashMap
{

    public static class DictionarySampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nDictionary Sample One");
            Dictionary<char, int> sourceMap = new Dictionary<char, int>
            {
                { 'A', 90},
                { 'B', 80},
                {'C', 70},
                {'D', 60}
            };

            Console.WriteLine($"Source for A: {sourceMap['A']}");
            Console.WriteLine($"Score for B: {sourceMap['B']}");
            Console.WriteLine($"Score for C: {sourceMap['C']}");
            Console.WriteLine($"Score for D: {sourceMap['D']}");

            char key = FindKeyByValue(sourceMap, 70);
            if (key != '\0')
            {
                Console.WriteLine($"Key for value 70: {key}");
            }
            else
            {
                Console.WriteLine("Value Not found");
            }
        }

        private static char FindKeyByValue(Dictionary<char, int> map, int value)
        {
            var pair = map.FirstOrDefault(pair => pair.Value == value);

            if (pair.Equals(default(KeyValuePair<char, int>)))
            {
                return '\0'; // Return `null` char if not found
            }
            return pair.Key;
        }
    }

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