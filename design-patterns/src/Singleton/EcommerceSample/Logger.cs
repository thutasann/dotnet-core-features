namespace design_patterns.src.Singleton.EcommerceSample
{
    /// <summary>
    /// Logger Singleton Class
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> lazyInstance = new(() => new Logger());

        private Logger()
        {

        }

        public static Logger Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}