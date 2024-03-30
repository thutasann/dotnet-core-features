namespace pure_DSA.src.KeyValuePair
{
    public static class KeyValuePairSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("KeyValuePair Sample One ===>");
            var person = new KeyValuePair<string, int>("Alice", 30);
            Console.WriteLine($"Name : {person.Key}, Age: {person.Value}");

            var people = new Dictionary<string, int>
            {
                { "Alice", 30},
                { "Bob", 40 },
                { "Charlie", 25 }
            };

            foreach (var kvp in people)
            {
                Console.WriteLine($"Name : {kvp.Key}, Age : {kvp.Value}");
            }
        }
    }
}