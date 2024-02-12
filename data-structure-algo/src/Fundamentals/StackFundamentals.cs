using System.Collections;

namespace data_structure_algo.src.Fundamentals
{
    /// <summary>
    /// The principle of stack structure operation is LIFO (last in first out)
    /// Stack applications:
    /// undo / redo functionality
    /// word reversal
    /// stack back/forward on browsers
    /// backtracking algorithms
    /// bracket verification
    /// </summary>
    public class StackFundamentals
    {

        /// <summary>
        /// Fundamental Stack Sample One
        /// </summary>
        public void StackSampleOne()
        {
            Console.WriteLine("------->> StackSampleOne");
            Stack myStack = new();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            Console.WriteLine("myStack");
            Console.WriteLine("\tCount: {0}", myStack.Count);
            Console.WriteLine("\tValues: ");
            PrintValues(myStack);
        }

        /// <summary>
        /// Generic Stack Sample
        /// </summary>
        public void GenericStackSample()
        {
            Console.WriteLine("------->> GenericStackSample");
            Stack<string> numbers = new();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Three");
            numbers.Push("Four");
            numbers.Push("Five");

            foreach (string number in numbers)
            {
                Console.WriteLine("Original Numbers -> {0}", number);
            }
            Console.WriteLine("Original Count {0}", numbers.Count);
            Console.WriteLine("Popping {0}", numbers.Pop());
            Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            Console.WriteLine("Popping {0}", numbers.Pop());
            Console.WriteLine("After Pop Count {0}", numbers.Count);


            // Create a copy of the stack, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Stack<string> stack2 = new(numbers.ToArray());
            Console.WriteLine("Contents of the First Copy:");
            foreach (string numString in stack2)
            {
                Console.WriteLine(numString);
            }

            // Create an array twice the size of the stack and copy the
            // elments of the stack, starting at the middle of the array
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Create a second stack, using the constructor that accepts an 
            // IEnumerable(Of T)
            Stack<string> stack3 = new(array2);

            Console.WriteLine("Contents of the second copy, with duplicates and nulls");
            foreach (string secondCopy in stack3)
            {
                Console.WriteLine("Second Copy ===> {0}", secondCopy);
            }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("stack2.Count = {0}", stack2.Count);
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            foreach (var obj in myCollection)
            {
                Console.WriteLine(" {0}", obj);
            }
        }
    }
}