namespace data_structure_algo.src.Basics.ThreadSample
{
    /// <summary>
    /// The `lock` keyword in c# is used to ensure that only one thread at a time can enter a critical section of code, thus preventing race conditions and ensuring thread safety. 
    /// </summary>
    public class LockKeywordSample
    {
        static int counter = 0;
        static object lockObject = new();
        private readonly int threadCount = 5;

        public void SampleOne()
        {
            var startTime = DateTime.Now;
            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(IncrementCounter);
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            var endTime = DateTime.Now;
            Console.WriteLine("Counter value after all threads finish: " + counter);
            Console.WriteLine($"This process took {(endTime - startTime) / 1000} seconds");
        }

        private void IncrementCounter()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }
    }
}