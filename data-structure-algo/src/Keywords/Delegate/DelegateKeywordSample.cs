namespace data_structure_algo.src.Keywords.Delegate
{
    /// <summary>
    /// In C#, a delegate is a type that represents references to methods with a particular signature. <br/>
    /// </summary>
    public class DelegateKeywordSample
    {
    }

    /// <summary>
    /// Declare a delegate type
    /// </summary>
    /// <param name="Message"></param>
    delegate void PrintMessage(string Message);

    public class DelegateKeywrodUsage
    {
        public void SampleOne()
        {
            PrintMessage printDelegate = PrintToConsole;

            printDelegate("Hello, World!");
        }

        private void PrintToConsole(string message)
        {
            Console.WriteLine("Delegate Method Result => " + message);
        }

    }

    // ---------------------------- Real-Life Sample ----------------------------
    public class EventArgs
    {
        public required string EventMessage { get; set; }
    }

    // Define delegate type for event handlers
    public delegate void EventHandler(object sender, EventArgs args);

    // Define event publisher class
    public class EventPublisher
    {
        // define event of type EventHandler
        public event EventHandler? EventOccured;

        // method to raise the event
        public void RaiseEvent(string message)
        {
            var args = new EventArgs { EventMessage = message };

            EventOccured?.Invoke(this, args);
        }
    }

    public class EventHandler1
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Handler 1 received event : {args.EventMessage}");
        }
    }

    public class EventHandler2
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"Handler 2 received event : {args.EventMessage}");
        }
    }

    public class DelegateEventSample
    {
        public void SampleOne()
        {
            var publisher = new EventPublisher();

            var handler1 = new EventHandler1();
            var handler2 = new EventHandler2();

            // Subscribe event handlers to the event
            publisher.EventOccured += handler1.HandleEvent;
            publisher.EventOccured += handler2.HandleEvent;

            publisher.RaiseEvent("Event message:");

            publisher.RaiseEvent("Another Event Mesage..");
        }
    }
}