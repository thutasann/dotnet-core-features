using System.Xml.Serialization;

namespace data_structure_algo.src.Basics.ThreadSample
{
    class Event
    {
        public string Name { get; set; }
        public DateTime Time { get; }

        public Event(string Name, DateTime Time)
        {
            this.Name = Name;
            this.Time = Time;
        }
    }

    /// <summary>
    /// Event Scheduler Class
    /// - The EventScheduler class manages a list of scheduled events and runs on its own thread (schedulerThread). It provides methods to start and stop the scheduler, as well as to schedule events.
    /// - The `SchedulerStart` method is executed on the scheduler thread. It continuously checks the current time and compares it to the scheduled times of the events. If an event's scheduled time has passed, it prints a message indicating that the event has occurred and removes the event from the list of scheduled events.
    /// - Events are scheduled using the ScheduleEvent method, which adds the event to the list of scheduled events.
    /// </summary>
    class EventScheduler
    {
        private readonly object lockObject = new();
        private List<Event> events = new();
        private bool running = true;

        public void Start()
        {
            Thread schedulerThread = new(SchedulerStart);
            schedulerThread.Start();
        }

        public void Stop()
        {
            running = false;
        }

        public void ScheduleEvent(Event ev)
        {
            lock (lockObject)
            {
                events.Add(ev);
                Console.WriteLine($"Scheduled event {ev.Name} at {ev.Time}");
            }
        }

        private void SchedulerStart()
        {
            while (running)
            {
                lock (lockObject)
                {
                    foreach (var item in events)
                    {
                        if (item.Time <= DateTime.Now)
                        {
                            Console.WriteLine($"Event {item.Name} occured at {DateTime.Now}");
                            events.Remove(item);
                        }
                    }
                }
                Thread.Sleep(1000); // check for events every second
            }
        }
    }

    /// <summary>
    /// Event Schduleing with Thread
    /// </summary>
    public class EventSchedulingWithThread
    {
        public void SampleOne()
        {
            EventScheduler eventScheduler = new();
            eventScheduler.Start();

            // Schedule some events
            eventScheduler.ScheduleEvent(new Event("Event 1", DateTime.Now.AddSeconds(2)));
            eventScheduler.ScheduleEvent(new Event("Event 2", DateTime.Now.AddSeconds(5)));
            eventScheduler.ScheduleEvent(new Event("Event 2", DateTime.Now.AddSeconds(8)));

            // wait for the scheudler to finish
            eventScheduler.Stop();

        }

    }
}