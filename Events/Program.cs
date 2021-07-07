using System;

namespace Events
{
    public delegate void Notify();
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

    public class ProcesssBusinessLogic
    {
        public event Notify ProcessComleted;
    }
    public class Publisher
    {
        public event Notify NotifyEvent;
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
            NotifySubscribers();
        }
        public void NotifySubscribers()
        {
            NotifyEvent?.Invoke();
        }
    }
    public class Subscriber
    {
        public void HandleEvent()
        {
            Console.WriteLine("Handling event.");
        }
    }
}
