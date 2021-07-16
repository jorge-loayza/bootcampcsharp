using System;

namespace Events
{
    //public delegate void Notify(object sender, EventArgs eventArgs);
    public delegate void Notify(CustomEventArgs customEventArgs);
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new();
            Subscriber subscriber = new();
            Subscriber subscriber2 = new();

            publisher.NotifyEvent += subscriber.HandleEvent;
            publisher.NotifyEvent += subscriber2.HandleEvent;


            publisher.DoSomething();
        }
    }

    public class Publisher
    {
        public event Notify NotifyEvent;
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
            CustomEventArgs customEventArgs = new()
            { TimeStamp = new DateTime(2121,5,5), Status = true};
            NotifySubscribers(customEventArgs);
        }
        public void NotifySubscribers(CustomEventArgs customEventArgs)
        {
            NotifyEvent?.Invoke(customEventArgs);
        }
    }
    public class Subscriber
    {
        public void HandleEvent(CustomEventArgs customEvent)
        {
            Console.WriteLine($"Handling customevent {customEvent.TimeStamp}, {customEvent.Status}");
        }
    }

    public class CustomEventArgs
    {
        public DateTime TimeStamp { get; set; }
        public bool Status { get; set; }

    }

    interface MyEventInterface
    {
        event Notify NotifyEvent;
    }
}
