using System.Text;

namespace advanced_c_.src.AsyncAwait
{
    public static class CPUBoundOperation
    {
        public static async Task<string> CalculateResultAsync(string stringInput)
        {
            string stringResult = await Task.Run(() => CalculateComplexOutput(stringInput));
            return stringResult;
        }

        public static string CalculateComplexOutput(string stringInput)
        {
            StringBuilder sb = new();
            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                sb.Append(stringInput[i]);
            }
            return sb.ToString();
        }
    }

    public static class IOBOundOperation
    {
        public static async Task<string> DownlaodDataAsync()
        {
            var httpClient = new HttpClient();
            string stringResult = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1").ContinueWith(task => CPUBoundOperation.CalculateComplexOutput(task.Result));
            return stringResult;
        }

        public static async Task MultipleTasks()
        {
            Console.WriteLine("------->> Multiple Tasks");
            var tasks = new Task<string>[] {
                new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/todos/1"),
                new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/todos/2"),
                new HttpClient().GetStringAsync("https://jsonplaceholder.typicode.com/todos/3")
            };
            await Task.WhenAll(tasks);

            Console.WriteLine($"Home page sizes: {tasks.Select(t => t.Result.Length.ToString()).Aggregate((str1, str2) => str1 + "," + str2)}");
        }

    }

    /// <summary>
    /// As a consequence, the call to the async method MethodAAsync() is not blocking the main thread. First, it prints A0 on the console and then returns to run the task B synchronously while the task A continues on some background threads.
    /// </summary>
    public static class AwaitKeywordImpact
    {
        public static async Task Main()
        {
            Console.WriteLine("Start Program");
            Task<int> taskA = MethodAAsync();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"B {i}");
                Task.Delay(50).Wait();
            }

            ConsoleWriteLine("Wait for taskA termination");

            await taskA;

            // Console.WriteLine(new System.Diagnostics.StackTrace());
            ConsoleWriteLine($"The result of taskA is {taskA.Result}");
        }

        private static async Task<int> MethodAAsync()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A {i}");
                await Task.Delay(100);
            }
            int result = 123;
            Console.WriteLine($"A returns result {result}");
            return result;
        }

        private static void ConsoleWriteLine(string str)
        {
            int threadId = Environment.CurrentManagedThreadId;
            Console.ForegroundColor = threadId == 1 ? ConsoleColor.White : ConsoleColor.Cyan;
            Console.WriteLine($"{str} {new string(' ', 26 - str.Length)}  Thread {threadId}");
        }
    }
}