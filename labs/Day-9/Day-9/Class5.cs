using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    //events

    //Define a deletgate that specifies the signature of the event handlers
    public delegate void NotifyEventHandler(string message);

    public class Publisher
    {
        public event NotifyEventHandler Notify;

        public void PublishEvent()
        {
            Console.WriteLine("Publishing an event");
            Notify.Invoke("event has been published");
        }
    }

    public class Subscriber
    {
        private string _name;
        public Subscriber(string name, Publisher pub)
        {
            _name = name;
            pub.Notify += HandleEvent;//subscring
            //pub.Notify -= HandleEvent;//un-subscring

        }

        void HandleEvent(string message)
        {
            Console.WriteLine($"{_name} reieved this message {message}");

        }
    }
    internal class Class5
    {

        public static void Main5()
        {
            Publisher publisher = new Publisher();

            Subscriber sub1 = new Subscriber("Subscriber 1",publisher);
            Subscriber sub2 = new Subscriber("Subscriber 2", publisher);
            publisher.PublishEvent();
        }
    }
}
