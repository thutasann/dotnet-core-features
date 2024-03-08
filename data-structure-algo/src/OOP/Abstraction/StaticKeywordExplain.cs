namespace data_structure_algo.src.OOP.Abstraction
{
    /// <summary>
    /// <h1>Static Keyword</h1> <br/>
    /// - Memory Efficiency:  Static members are allocated only once for the entire lifetime of the application. <br/>
    /// - Performance : Since static members are associated with the type itself rather than with instances, accessing static members can sometimes be more efficient than accessing instance members, particularly in performance-critical code paths. <br/>
    /// - Singleton Pattern : The static keyword is often used in conjunction with the Singleton design pattern to ensure that only one instance of a class exists in the application. 
    /// </summary>
    public class StaticKeywordExplain
    {
    }

    /// <summary>
    /// In this example, both the Pi field and the Square method are declared as static in the MathUtility class, allowing them to be accessed directly through the type name without needing to create an instance of MathUtility.
    /// </summary>
    public static class MathUtility
    {
        public static readonly double pi = 3.1459;

        public static double GetSquare(double x)
        {
            return x * x;
        }
    }

    public class Usage
    {
        public void SampleOne()
        {
            Console.WriteLine("The value of pi is: " + MathUtility.pi);

            double result = MathUtility.GetSquare(5);
            Console.WriteLine("Square of 5 is : " + result);
        }
    }

    // ----------------------------- Complex Usage -----------------------------
    public static class StaticLogger
    {
        private static int LogCount;

        static StaticLogger()
        {
            LogCount = 0;
            Console.WriteLine("LogCount Initialized");
        }

        public static int GetLogCout
        {
            get { return LogCount; }
        }

        public static void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} => {message}");
            LogCount++;
        }
    }

    public static class StaticDatabase
    {
        public static void SaveData(string data)
        {
            Console.WriteLine($"Data saved to database: {data}");
        }
    }

    public class StaticDatabaseUsage
    {
        public void SampleOne()
        {
            Console.WriteLine($"Initializing Log Count : {StaticLogger.GetLogCout}");

            StaticLogger.Log("Application Started....");
            StaticLogger.Log("Processing data");

            Console.WriteLine($"Updated Log Count : {StaticLogger.GetLogCout}");

            StaticDatabase.SaveData("Sample Data");

            Console.WriteLine($"Log count after accessing Logger class: {StaticLogger.GetLogCout}");

        }
    }
}