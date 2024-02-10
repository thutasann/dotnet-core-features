namespace data_structure_algo.src.Basics
{
    public class LambdaExpression
    {
        public void SampleOne()
        {
            Console.WriteLine("------>> Lambda Expression");

            // Example 1: Lambda function as an inline delegate
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(1, 2));

            // Example 2: Lambda function in a LINQ query
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // Example 3: Lambda function as an argument to a method
            Action<string> printMessage = message => Console.WriteLine("Printed Message " + message);
            printMessage("Hello, world");

            // Example 4: Lambda function with multiple parameters
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine("Mulitplication Result " + multiply(3, 4));

            // Example 5: Lambda function with no parameters
            Func<int> getRandomNumber = () => new Random().Next(1, 101);
            Console.WriteLine("Random Number Result " + getRandomNumber());

            // Example 6: Lambda function in a list operation
            var names = new string[] { "Alice", "Bob", "Charlie" };
            var uppercaseNames = names.Select(name => name.ToUpper());
            Console.WriteLine("Uppercase names: " + string.Join(", ", uppercaseNames));

        }
    }
}