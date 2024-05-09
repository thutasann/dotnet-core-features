namespace LINQExamples_1.src.LINQ_Operators
{
    public static class ConcatenationOperator
    {
        public static void ConcatSample()
        {
            Console.WriteLine("\nConcat Sample : ");
            List<int> integersList1 = new() { 1, 2, 3, 4 };
            List<int> integersList2 = new() { 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> concatedList = integersList1.Concat(integersList2);

            foreach (var item in concatedList)
            {
                Console.WriteLine($"Item - {item}");
            }
        }
    }
}