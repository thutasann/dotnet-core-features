using System.Text;

namespace data_structure_algo.src.Basics
{
    /// <summary>
    /// Async/Await Sample <br/>
    /// <a href="https://blog.ndepend.com/c-async-await-explained/">Source</a>
    /// </summary>
    public class AsyncAwaitSample
    {
        /// <summary>
        /// When DoSomeWorkAsync is awaited, the control returns to the Main method. Once the asynchronous work is completed, Main resumes execution and prints "Program completed."
        /// </summary>
        public async Task SampleOne()
        {
            Console.WriteLine("Starting the program...");
            await DoSomeAsyncWork();
            Console.WriteLine("Program Completed...");
        }

        private async Task DoSomeAsyncWork()
        {
            Console.WriteLine("Doing some work asynchronously...");
            await Task.Delay(2000);
            Console.WriteLine("Work Completed");
        }
    }

    /// <summary>
    /// <h1> CPU Bound </h1>
    /// To execute a CPU-bound operation on a background thread, 
    /// you initiate it using the Task.Run() method. 
    /// This method returns a task object that can be awaited through the await C# keyword.
    /// </summary>
    public class CPUBoundAsyncAwait
    {
        public async Task<string> CalculateResultAsync(string stringInput)
        {
            Console.WriteLine("------>> Async/Await CPU Bound");
            string stringResult = await Task.Run(() => CalculateComplexOutput(stringInput));
            return stringResult;
        }

        private string CalculateComplexOutput(string stringInput)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                sb.Append(stringInput[i]);
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// <h1> I/O-Bound </h1> <br/>
    /// They also encompass I/O-Bound operations  <br/>
    /// like reading file content and downloading a resource from the website <br/>
    /// the `await` keyword is used to pause the execution while waiting for a method marked as `async` <br/>
    /// - The code after `await` statement - which is return `stringResult`; here - is resumed once the time-consuming job ends. <br/>
    /// - The `async` method returns immediately once the `await` keyword is met. <br/>
    /// - That's why asynchronous methods are said to be `non-blocking`.
    /// </summary>
    public class IOBoundAsyncAwait
    {
        // Method declared as `async` and returns a `Task<string>`
        public async Task<string> DownloadAsync()
        {
            using var httpClient = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            // Use the `await` keyword to execute a non-blocking GET request
            string stringResult = await httpClient.GetStringAsync(url);

            // Return the result obtained when the request is completed.
            return stringResult;
        }
    }

    /// <summary>
    /// Async/Await Complex Usage
    /// </summary>
    public class AsyncAwaitFetchAPIs
    {
        public async Task FetchAPIs()
        {
            Console.WriteLine("Fetching Dat from multiple APIS.....");

            List<string> urls = new()
            {
                "https://jsonplaceholder.typicode.com/posts/1",
                "https://jsonplaceholder.typicode.com/posts/2",
                "https://jsonplaceholder.typicode.com/posts/3"
            };

            using HttpClient httpClient = new();

            List<Task<string>> fetchTasks = new();

            foreach (string url in urls)
            {
                fetchTasks.Add(FetchDataAsync(httpClient, url));
            }

            string[] results = await Task.WhenAll(fetchTasks);

            foreach (string result in results)
            {
                Console.WriteLine($"Received Data {result}");
            }

            Console.WriteLine("All data fetched and processed");
        }

        private static async Task<string> FetchDataAsync(HttpClient httpClient, string url)
        {
            Console.WriteLine($"Fetching Data from {url}");

            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);

            responseMessage.EnsureSuccessStatusCode();

            return await responseMessage.Content.ReadAsStringAsync();
        }
    }

}