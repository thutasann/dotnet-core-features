namespace data_structure_algo.src.Basics.ThreadSample
{
    public class ThreadSample
    {
        // ---------------------------- Thread Sample ----------------------------
        private void WorkderMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Worker Thread is doing some work...");
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Sample One
        /// </summary>
        public void SampleOne()
        {
            // create a new thread and specify the method to execute
            Thread thread = new(WorkderMethod);

            // start the thread
            thread.Start();

            // Main thread continues execution while the worker thread is running
            Console.WriteLine("Main Thread is working....");

            // Wait for the worker thread to complete
            thread.Join();

            Console.WriteLine("Workder Thread has completed");
        }


        // ---------------------------- Real Life Sample ----------------------------
        public class Task
        {
            public int Id { get; }
            public int Duration { get; }

            public Task(int Id, int Duration)
            {
                this.Id = Id;
                this.Duration = Duration;
            }
        }

        static int taskIdCounter = 0;

        private Task GetNextTask()
        {
            // Simulate fetching the next task from a queu or database
            // In this example, we create tasks with random durations for simplicity
            Random random = new();
            int taskId = Interlocked.Increment(ref taskIdCounter);
            int duration = random.Next(100, 1000);
            return new Task(taskId, duration);
        }

        /// <summary>
        /// Thread RealLife Sample
        /// </summary>
        public void RealLifeSampleOne()
        {
            const int NumTasks = 10;
            const int NumThreads = 3;

            // Create an array to hold the tasks
            Task[] tasks = new Task[NumTasks];

            // Create a mutex to synchronize access to the shared resource
            Mutex mutex = new Mutex();

            // Create and start multiple threads to perform tasks concurrently
            Thread[] threads = new Thread[NumThreads];

            for (int i = 0; i < NumThreads; i++)
            {
                threads[i] = new Thread(() =>
                {
                    while (true)
                    {
                        Task task = GetNextTask();
                        if (task == null)
                            break;

                        // Simulate processing the task
                        Thread.Sleep(task.Duration);

                        // Acquire the mutex to access the shared resource
                        mutex.WaitOne();
                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} processed task {task.Id}");
                        mutex.ReleaseMutex();
                    }
                });
                threads[i].Start();
            }

            // Wait for all threads to complete
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("All tasks have been processed.");

        }
    }
}