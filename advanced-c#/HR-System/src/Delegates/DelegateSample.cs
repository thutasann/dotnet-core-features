namespace advanced_c_.src.Delegates
{
    /// <summary>
    /// <h1> Delegate Sample </h1>
    /// - Type-safe function pointer <br/>
    /// - A variable defined as a delegate is a reference type variable that can hold a reference to a method <br/>
    /// - In orderfor a delegate to reference a particular method. <br/>
    /// - When a developer instantiates a delegate, the developer can associate its instance with any method with compatible parameters. <br/>
    /// - the developer can invoke or call the method through the delegate instance <br/>
    /// - A delegate can reference both static methods and instance.
    /// - Delegate type can be accessed from anywherer within the program class
    /// </summary>
    public class DelegateSample
    {
    }

    // ----------------- Delegate that reference a static method and Instance method
    delegate void LogDel(string message);

    public static class DelegateReferenceToStaticMethod
    {
        public static void SampleOne()
        {
            Console.WriteLine("------>> Delegate Reference to static method and Instance method 🚀");
            LogDel logDel1 = new(LogTextToScreen);
            LogDel logDel2 = new(Log.LogTextToFile);
            logDel1.Invoke("This is Text Mesage");
            logDel2.Invoke("This is the Text Mesage Two");

            // multicast delegate
            LogDel LogToScreenDel, LogToFileDel;
            LogToScreenDel = new(LogTextToScreen);
            LogToFileDel = new(Log.LogTextToFile);

            LogDel multipleLogDel = LogToScreenDel + LogToFileDel;
            multipleLogDel("this is multiple LogDel");

            LogTextWithDelArg(multipleLogDel, "This is with Arguement");
        }

        private static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");
        }

        private static void LogTextToFile(string text)
        {
            using (StreamWriter sw = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
                Console.WriteLine("Text File created...");
            }
        }

        private static void LogTextWithDelArg(LogDel logDel, string text)
        {
            logDel(text);
        }

    }

    public static class Log
    {
        public static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");
        }

        public static void LogTextToFile(string text)
        {
            using (StreamWriter sw = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
                Console.WriteLine("Text File created...");
            }
        }

    }


}