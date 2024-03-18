namespace data_structure_algo.src.Keywords.EventKeyword
{
    /// <summary>
    /// <h1>Event Keyword </h1> <br/>
    /// It is used to declare events in classes or structs. <br/>
    /// Events enable a class or object to notify other classes or objects <br/>
    /// when something of interest occurs. <br/> 
    /// - Event provides a way for classes to communicate with other classes or components in a loosely coupled manner.
    /// </summary>
    public class EventKeywordSample
    {
    }

    public class Button
    {
        // Declare an event using the event keyword
        public event EventHandler? Clicked;

        // Method to simulate a button click
        public void Click()
        {
            // Raise the event when button is clicked.
            OnClicked(EventArgs.Empty);
        }

        // Method to raise the Clicked event
        protected virtual void OnClicked(EventArgs e)
        {
            Clicked?.Invoke(this, e);
        }
    }

    public class EventButtonUsage
    {
        public void SampleOne()
        {
            Button button = new();

            button.Clicked += (sender, e) =>
            {
                Console.WriteLine("Button Clicked!");
            };

            button.Click();
        }
    }
}