namespace data_structure_algo.src.Keywords.Delegate
{
    public delegate void CallbackDelegate(string message);

    public class Worker
    {
        public void DoWork(CallbackDelegate callback)
        {
            Console.WriteLine("Worker is doing some work...");
            callback("Work is done!");
        }
    }

    public class DelegateCallbackUsage
    {
        public void SampleOne()
        {
            Worker worker = new();
            worker.DoWork(CallbackMethod);
        }

        private static void CallbackMethod(string message)
        {
            Console.WriteLine($"Received callback : {message}");
        }
    }
}