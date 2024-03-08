namespace data_structure_algo.src.Basics
{
    /// <summary>
    /// Async/Await Sample
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