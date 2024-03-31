using System.Collections;

namespace pure_DSA.src.StackSamples
{
    public static class StackSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nStack Sample One ===> ");
            Stack myStack = new();
            myStack.Push("hello");
            myStack.Push("World");
            PrintValues(myStack);
        }

        public static void SampleTwo()
        {
            Console.WriteLine("\nStack Sample Two ===> ");
            Stack<string> numbers = new();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Three");
            numbers.Push("Four");
            numbers.Push("Five");

            foreach (string number in numbers)
            {
                Console.WriteLine($"Original Numbers => {number}");
            }

            Stack<string> stack2 = new(numbers.ToArray());
            foreach (string number in stack2)
            {
                Console.WriteLine($"Content of the First Copy => {number}");
            }

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);
            foreach (string number in numbers)
            {
                Console.WriteLine($"After sized, => {number}");
            }

            Stack<string> stack3 = new(array2);
            foreach (string number in stack3)
            {
                Console.WriteLine($"Second Copy Including Duplicates and Nulls => {number}");
            }
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            foreach (var item in myCollection)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}