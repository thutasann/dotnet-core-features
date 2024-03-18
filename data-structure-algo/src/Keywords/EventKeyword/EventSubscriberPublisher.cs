namespace data_structure_algo.src.Keywords.EventKeyword
{
    /// <summary>
    /// Define a Event Delegate
    /// </summary>
    public delegate void EventHandler(object sender, EventArgs e);

    /// <summary>
    /// Class with an event
    /// </summary>
    public class Publisher
    {
        // Define the event using the event keyword
        public event EventHandler? SomethingHappened;

        // Method to raise the event
        protected virtual void OnSomethingHappened()
        {
            // Check if any subscribers exist before raising the event
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }

        // Method to trigger the event
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
            OnSomethingHappened(); // raise the event
        }
    }

    /// <summary>
    /// Subscriber class
    /// </summary>
    public class Subscriber
    {
        // Event Handler Method
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Something happened!");
        }
    }

    public class EventSubscriberPublisherUsage
    {
        public void SampleOne()
        {
            Publisher publisher = new();
            Subscriber subscriber = new();

            // subscribe to the event
            publisher.SomethingHappened += subscriber.HandleEvent;

            // Trigger the event
            publisher.DoSomething();
        }
    }
}