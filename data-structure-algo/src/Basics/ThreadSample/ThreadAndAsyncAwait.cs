namespace data_structure_algo.src.Basics.ThreadSample
{
    public class ThreadAndAsyncAwait
    {
        public void SampleOne()
        {
            Thread thread = new(DoAsyncWork);
            thread.Start();

            Console.WriteLine("Main Thread is working....");
            thread.Join();

            Console.WriteLine("Main Thread Finished.....");
        }

        private static void DoAsyncWork()
        {
            Console.WriteLine("Thread is doing some async work....");

            Task.Run(async () =>
            {
                await Task.Delay(4000);

                Console.WriteLine("Async work completed.");
            }).GetAwaiter().GetResult(); // Block until the asynchronous operation completes
        }
    }
}