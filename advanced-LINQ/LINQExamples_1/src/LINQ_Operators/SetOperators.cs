using System.Runtime.InteropServices;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class SetOperators
    {
        public static void DistinceSample()
        {
            Console.WriteLine("\nDistince Operator : ");
            List<int> list = new() { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
            var result = list.Distinct();
            foreach (var item in result)
            {
                Console.WriteLine($"item : {item}");
            }
        }

        public static void ExceptSample()
        {
            Console.WriteLine($"\nExcept Operator: ");
            IEnumerable<int> collection1 = new List<int>() { 1, 2, 3, 4 };
            IEnumerable<int> collection2 = new List<int>() { 3, 4, 5, 6 };
            var result = collection1.Except(collection2);
            foreach (var item in result)
            {
                Console.WriteLine($"item : {item}");
            }
        }
    }

}